/*
 * Eetu Piispa
 * 6.12.2017    - first version
 * for IoT Project
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace XYPlotterProject {
    class TopicList : Topic{
        Topic[] _list;

        public TopicList() { }


        //
        //  Add a new topic
        //
        public void Add(Topic topic) {
            if (Length() > 0) {
                Topic[] tempList = new Topic[Length() + 1];
                Console.WriteLine("tempList size: " + tempList.Length + "; _list size: " + Length());
                for (int i = 0; i < Length(); i++) {
                    tempList[i] = _list[i];
                }
                tempList[tempList.Length-1] = topic;
                _list = tempList;
            } else {
                Console.WriteLine("_list size: " + Length());
                _list = new Topic[] { topic };
            }
        }


        //
        //  Remove topic from list
        //
        public void Remove(int i) {
            List<Topic> tempList = _list.ToList<Topic>();
            tempList.RemoveAt(i);
            _list = tempList.ToArray<Topic>();
        }


        //
        //  Gets a topic by given integer
        //
        public Topic Get(int i) {
            return _list[i];
        }


        //
        //  Gets a topic by given string
        //
        public int Get(string name) {
            int t = 0;
            for (int i = 0; i < Length(); i++) {
                if (_list[i].Name == name) {
                    t = i;
                }
            }
            return t;
        }


        //
        //  Checks if topic exists in list
        //
        public bool Exists(string name) {
            bool b = false;
            for (int i = 0; i < Length(); i++) {
                if (Length() > 0) {
                    if (_list[i].Name == name) {
                        b = true;
                    }
                }
            }
            return b;
        }


        //
        //  Returns the amount of topics in this list
        //
        public int Length() {
            int size = 0;
            if (_list != null)
                size = _list.Length;
            return size;
        }
    }
}
