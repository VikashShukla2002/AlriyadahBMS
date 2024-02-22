using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AlriyadahBMS.Shared.Helper
{
    public static class JwtParser
    {
        public static Dictionary<string, object>? GetJwtPayloadData(string? jwt)
        {
            if (string.IsNullOrEmpty(jwt)) return null;

            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
            return keyValuePairs;
        }
        public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();

            if (GetJwtPayloadData(jwt) is Dictionary<string, object> payloadData)
            {
                claims.AddRange(payloadData.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString() ?? "")));
            }

            return claims;
        }
        private static byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
