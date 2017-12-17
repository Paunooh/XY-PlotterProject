/*
 * Eetu Piispa
 * 6.12.2017    - first version
 * for IoT Project
 */

namespace XYPlotterProject {
    class Topic {
        private string _name = "";
        private string _messages = "";

        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        public string Messages {
            get { return _messages; }
            set { _messages = value; }
        }

        public Topic() {
            _name = "Null";
        }
        public Topic(string name) {
            _name = name;
        }

        public void Message(string ms) {
            _messages = _messages + ms + "\r\n";
        }
        public string GetMessages() {
            return _messages;
        }
    }
}
