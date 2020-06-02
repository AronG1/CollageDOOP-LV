using System;
using System.Collections.Generic;
using System.Text;

namespace LV_4
{
    interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
    class EmailValidator : IEmailValidatorService
    {
        private int MinLength;
        public EmailValidator(int minLength)
        {
            MinLength = minLength;
        }

        public bool IsValidAddress(string candidate)
        {
            if (candidate.Length < MinLength) return false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(candidate);
                return addr.Address == candidate;
            }
            catch
            {
                return false;
            }
        }
    }
}
