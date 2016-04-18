using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2as1.AutoFramework
{
    public enum Role
    {
        Delivery_Lead,
        Developer,
        Manager,
        Tester
    }

    public class StoryBasics
    {

        public static StoryDetail AsA(Role role)
        {
            StoryDetail storyDetail = new StoryDetail();
            return storyDetail;
        }
    }

    public class StoryDetail
    {
        private string benefit;
        private string objective;

        public StoryDetail IWant(string objective)
        {
            this.objective = objective;
            return this;
        }

        public StoryDetail SoThat(string benefit)
        {
            this.benefit = benefit;
            return this;
        }
    }
}
