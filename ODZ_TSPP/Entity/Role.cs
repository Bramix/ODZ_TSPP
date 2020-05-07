using System.Text;

namespace ODZ_TSPP.Entity
{
    public class Role
    {
        private int id;
        private string nameOfRole;
        private string password;

        public Role(int id, string nameOfRole, string password)
        {
            this.id = id;
            this.nameOfRole = nameOfRole;
            this.password = password;
        }

        public Role(string nameOfRole, string password)
        {
            this.nameOfRole = nameOfRole;
            this.password = CreateMd5Hash(password);
        }

        protected bool Equals(Role other)
        {
            return nameOfRole.ToLower() == other.nameOfRole.ToLower() && password == other.password;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Role) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((nameOfRole != null ? nameOfRole.GetHashCode() : 0) * 397) ^ (password != null ? password.GetHashCode() : 0);
            }
        }

        private string CreateMd5Hash(string password)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        } 
    }
}