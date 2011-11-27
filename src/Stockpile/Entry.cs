namespace Stockpile
{
    using System;

    public class Entry
    {
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresIn { get; set; }
        public bool Compressed { get; set; }
        public object Value { get; set; }

        public object RawValue { get { return Value; } }

        public Entry(object value, object options = null)
        {
            var opts = options.AsDictionary();


        }

        public static Entry Create(object rawValue, DateTime createdAt, object options = null)
        {
            var opts = options.AsDictionary();
            var entry = new Entry(null);
            entry.Value = rawValue;
            entry.CreatedAt = createdAt;
            entry.Compressed = opts["compressed"].AsBoolean();
            return entry;
        }
    }
}
