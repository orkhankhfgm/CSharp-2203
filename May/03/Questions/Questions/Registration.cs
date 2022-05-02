using System;

namespace Questions
{
    class Registration
    {
        public static void RegisterNewUser(User user)
        {
            var result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);
            result = GeneralHelper.CheckName(user.Name);

            if (!result)
                throw new Exception(UserMessages.NameFormatException);
        }
    }
}
