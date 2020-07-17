using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_NestedClass
{
    class Program
    {
        class Configuration
        {
            List<ItemValue> list = new List<ItemValue>();

            public void SetConfig(string item, string value)
            {
                ItemValue iv = new ItemValue();
                iv.SetValue(this, item, value);
            }

            public string GetConfig(string item)
            {
                foreach(ItemValue iv in list)
                {
                    if (iv.Getitem() == item)
                        return iv.GetValue();
                }
                return null;
            }
            class ItemValue
            {
                private string item, value;

                public void SetValue(Configuration config, string item, string value)
                {
                    this.item = item;
                    this.value = value;

                    bool found = false;
                    for(int i = 0; i < config.list.Count; i++)
                    {
                        if (config.list[i].item == item)
                        {
                            found = true;
                            config.list[i] = this;
                            break;
                        }
                    }

                    if (found == false)
                        config.list.Add(this);
                }
                public string Getitem()
                {
                    return item;
                }
                public string GetValue()
                {
                    return value;
                }
            }
        }
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("version", "1.0.0");
            config.SetConfig("size", "3,000,000 KB");

            Console.WriteLine(config.GetConfig("version"));
            Console.WriteLine(config.GetConfig("size"));

            config.SetConfig("version", "1.0.1");
            Console.WriteLine(config.GetConfig("version"));
        }
    }
}
