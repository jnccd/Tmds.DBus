// Copyright 2016 Tom Deseyn <tom.deseyn@gmail.com>
// This software is made available under the MIT License
// See COPYING for details

using System.Threading;
using System.Threading.Tasks;

namespace Tmds2.DBus.Protocol
{
    delegate Task<Message> MethodHandler(Message message);
}