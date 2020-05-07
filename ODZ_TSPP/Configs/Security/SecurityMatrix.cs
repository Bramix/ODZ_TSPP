using System.Collections.Generic;

namespace ODZ_TSPP
{
    public class SecurityMatrix
    {
        public static Dictionary<string, Dictionary<string, bool>> securityMatrix
            = new Dictionary<string, Dictionary<string, bool>>()
            {
                {
                    "user", new Dictionary<string, bool>()
                    {
                        {UserOperations.Edit.ToString(), false},
                        {UserOperations.Delete.ToString(), false}
                    }
                    
                },
                {
                    "admin", new Dictionary<string, bool>()
                    {
                        {UserOperations.AllowAll.ToString(), true},
                    }
                }

            };
        
    }
}