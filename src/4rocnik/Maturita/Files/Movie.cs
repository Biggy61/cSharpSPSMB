namespace Files
{
    public class Movie
    {
        public string FilmName { get; set; }
        public string Genre { get; set; }
        public string LeadStudio { get; set; }
        public int AudienceScore { get; set; }
        public decimal Profitability { get; set; }
        public int RottenTomatoes { get; set; }
        public string Gross {get; set;}
        public int Year { get; set; }

        public Movie(string filmName, string genre, string leadStudio, int audienceScore, decimal profitability, int rottenTomatoes, string gross, int year)
        {
            FilmName = filmName;
            Genre = genre;
            LeadStudio = leadStudio;
            AudienceScore =  audienceScore;
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