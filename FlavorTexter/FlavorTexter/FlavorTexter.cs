namespace FlavorTexter
{
    public static class FlavorTexter
    {
        public static string GetFlavorText(bool destructive = false)
        {
            return $"{Verber.GetVerb(destructive)} {Nouner.GetNoun()}";
        }
    }
}
