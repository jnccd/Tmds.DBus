// Copyright 2016 Tom Deseyn <tom.deseyn@gmail.com>
// This software is made available under the MIT License
// See COPYING for details

using System;
using Tmds2.DBus.Protocol;

namespace Tmds2.DBus.CodeGen
{
    internal class ArgumentDescription
    {
        public ArgumentDescription(string name, Signature signature, Type type)
        {
            Name = name;
            Signature = signature;
            Type = type;
        }

        public string Name { get; }
        public Signature Signature { get; }
        public Type Type { get; }
    }
}