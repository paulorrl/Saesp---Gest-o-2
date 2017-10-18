using SAESP.Users.Domain.Validators;
using System.Text;

namespace SAESP.Users.Domain.ValueObjects
{
    public class Password
    {
        public string Pass { get; private set; }

        public string ConfirmPass { get; private set; }

        public Password(string password, string confirmPassword)
        {
            Pass = password;
            ConfirmPass = confirmPassword;

            Pass = this.Validate()
                ? EncryptPassword(password)
                : null; // Se Validate() retornar false , não salvará no banco, pois, não haverá usuário sem senha.
        }

        private string EncryptPassword(string pass)
        {
            if (string.IsNullOrEmpty(pass)) return null;

            var password = (pass += "SALT_KEY_HERE");
            var md5 = System.Security.Cryptography.MD5.Create();
            var data = md5.ComputeHash(Encoding.Default.GetBytes(password));
            var sbString = new StringBuilder();
            foreach (var t in data)
                sbString.Append(t.ToString("x2"));

            return sbString.ToString();
        }
    }
}