namespace Files
{
    public class Movie
    {
        public string FilmName { get; set; }
        public string Genre { get; set; }
        public string LeadStudio { get; set; }
        public string AudienceScore { get; set; }
        public string Profitability { get; set; }
        public string RottenTomatoes { get; set; }
        public string Gross {get; set;}
        public string Year { get; set; }

        public Movie(string filmName, string genre, string leadStudio, string audienceScore, string profitability, string rottenTomatoes, string gross, string year)
        {
            FilmName = filmName;
            Genre = genre;
            LeadStudio = leadStudio;
            AudienceScore = audienceScore;
            Profitability = profitability;
            RottenTomatoes = rottenTomatoes;
            Gross = gross;
            Year = year;
        }
        
        public override string ToString()
        {
            return $"Name: {this.FilmName}, Genre: {Genre}, LeadStudio: {LeadStudio}, AudienceScore: {AudienceScore} , Profitability: {Profitability}, RottenTomatoes: {RottenTomatoes}, Gross: {Gross}, Year: {Year} ";
        }
    }
    
    
}