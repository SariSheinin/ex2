﻿namespace ex2
{
    public enum Preference
    {
        A,B,C,D,E
    }
    public class Taskk
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TargetDate { get; set; }
        public Preference MyPreference { get; set; }
    }
}
