using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("word")]
    public string word { get; set; }

    [JsonProperty("similarCount")]
    public int similarCount { get; set; }

    [JsonProperty("similarWords")]
    public string[] similarWords { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
