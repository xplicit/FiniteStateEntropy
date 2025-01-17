﻿using System;

namespace FiniteStateEntropy
{
    public ref struct FseCompressTable
    {
        public ushort tableLog;
        public ushort maxSymbolValue;
        public Span<ushort> nextStateNumber;
        public Span<FseSymbolCompressionTransform> symbolTT;
    }
}
