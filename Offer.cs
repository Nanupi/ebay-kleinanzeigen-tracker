class Offer
{
    public long Id { get; }
    public string Title { get; }
    public string Description { get; }
    public string Url { get; }
    public string Thumbnail { get; }
    public string Price { get; }
    public DateTime? RemovedDate { get; set; }

    public Offer(long id, string title, string description, string url, string thumbnail, string price, DateTime? removedDate = null)
    {
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Url = url;
        this.Thumbnail = thumbnail;
        this.Price = price;
        this.RemovedDate = removedDate;
    }
}
