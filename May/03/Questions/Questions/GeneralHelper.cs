namespace Questions
{
    public static class GeneralHelper
    {
        public static bool CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                    return false;
            }

            return true;
        }
    }
}
