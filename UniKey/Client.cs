using System;
using System.Dynamic;
using System.Security.Policy;
using GcmSharp.Serialization;
using Newtonsoft.Json;
using RestSharp;
using UnikeyAPI.Locks;
using UnikeyAPI.Users;

namespace UnikeyAPI
{
    public class Client
    {
        private static readonly Lazy<RestClient> Rest = new Lazy<RestClient>(() => new RestClient("https://cirrusstaging.unikey.com/2015071001"));

        private readonly string _accessToken;

        public Client(string accessToken)
        {
            _accessToken = accessToken;
        }

        private static RestRequest BuildRequest(string url, Method method, BaseRequest requestDto = null)
        {
            var request = new RestRequest(url, method)
            {
                RequestFormat = DataFormat.Json,
                JsonSerializer = NewtonsoftJsonSerializer.Default
            };

            if (requestDto != null)
            {
                request.AddBody(requestDto);
            }

            return request;
        }

        private T ExecuteRequest<T>(string url, Method method, BaseRequest requestDto = null)
        {
            var request = BuildRequest(url, method, requestDto);
            request.AddHeader("Authorization", $"Bearer {_accessToken}");

            var response = Rest.Value.Execute(request);

            return JsonConvert.DeserializeObject<T>(response.Content);
        }


        private static T ExecuteUnauthenticatedRequest<T>(string url, Method method, BaseRequest requestDto = null)
        {
            var request = BuildRequest(url, method, requestDto);
            var response = Rest.Value.Execute(request);
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static OAuthTokenCreateResponse CreateToken(string clientId, string clientSecret, string authorizationCode)
        {
            var requestDto = new OAuthTokenCreateRequest()
            {
                Code = authorizationCode,
                ClientId = clientId,
                ClientSecret = clientSecret,
                GrantType = "authorization_code"
            };

            return ExecuteUnauthenticatedRequest<OAuthTokenCreateResponse>("/oauth/token", Method.POST, requestDto);
        }

        public UserGetResponse Me()
        {
            return ExecuteRequest<UserGetResponse>("/me", Method.GET);
        }

        public UserGetResponse Users(string userId)
        {
            return ExecuteRequest<UserGetResponse>($"/users/{userId}", Method.GET);
        }

        public UserLocksGetResponse Locks(string userId)
        {
            return ExecuteRequest<UserLocksGetResponse>($"/users/{userId}/locks", Method.GET);
        }

        public LockCommandCreateResponse CreateLockCommand(string lockId, string type)
        {
            var requestDto = new LockCommandCreateRequest()
            {
                LockId = lockId,
                Type = type
            };

            return ExecuteRequest<LockCommandCreateResponse>("/lock_commands", Method.POST, requestDto);
        }
    }
}