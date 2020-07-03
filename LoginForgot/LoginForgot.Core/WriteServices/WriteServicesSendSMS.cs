using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace LoginForgot.Core.WriteServices
{
    public class WriteServicesSendSMS
    {
        private readonly string accountSid = "AC4fb20e85fd648fb4113326a958792eac";
        private readonly string authToken = "27276b2324d2c67a2bc8f7035e4a07be";

        public string SendSMS(string to, string code)
        {
            TwilioClient.Init(accountSid, authToken);
            var message = MessageResource.Create(
                body: "This is your Code: " + code + ". You have 15 minutes to used.",
                from: new Twilio.Types.PhoneNumber("+12058528046"),
                to: new Twilio.Types.PhoneNumber(to)
            );
            return message.Sid;
        }
    }
}
