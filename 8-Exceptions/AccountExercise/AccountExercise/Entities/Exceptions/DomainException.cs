﻿using System;

namespace AccountExercise.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException (string message) : base(message) { }
    }
}
