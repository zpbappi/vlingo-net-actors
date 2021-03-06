﻿// Copyright (c) 2012-2019 Vaughn Vernon. All rights reserved.
//
// This Source Code Form is subject to the terms of the
// Mozilla Public License, v. 2.0. If a copy of the MPL
// was not distributed with this file, You can obtain
// one at https://mozilla.org/MPL/2.0/.

using System;

namespace Vlingo.Actors
{
    public interface IAddress : IComparable<IAddress>
    {
        long Id { get; }
        long IdSequence { get; }
        string IdSequenceString { get; }
        string IdString { get; }
        T IdTyped<T>();
        string Name { get; }
        bool IsDistributable { get; }
    }
}