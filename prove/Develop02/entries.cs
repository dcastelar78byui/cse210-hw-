using System;
using System.IO;
using System.Collections.Generic;

public class Entry 
{
    public String _prompt;
    public DateTime _date;
    public String _response;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }

        public override string ToString()
    {
        return $"[{_date}] {_prompt}: {_response}";
    }

}

