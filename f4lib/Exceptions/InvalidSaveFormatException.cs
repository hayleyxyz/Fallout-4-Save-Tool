﻿using System;
using System.Collections.Generic;
using System.Text;

namespace f4lib.Exceptions {
    class InvalidSaveFormatException : Exception {
        public InvalidSaveFormatException(string message) : base(message) {

        }
    }
}
