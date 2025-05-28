public async Task<string> FetchDataAsync()
{
    using (HttpClient client = new HttpClient())
    {
        return await client.GetStringAsync("https://example.com");
    }
}
