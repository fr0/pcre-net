﻿using System;
using PCRE.Wrapper;

namespace PCRE.Dfa
{
    [Flags]
    public enum PcreDfaMatchOptions : long
    {
        None = 0,

        Anchored = PatternOptions.Anchored,

        NotBeginningOfLine = PatternOptions.NotBol,
        NotEndOfLine = PatternOptions.NotEol,
        NotEmpty = PatternOptions.NotEmpty,
        NotEmptyAtStart = PatternOptions.NotEmptyAtStart,

        NewLineCr = PatternOptions.NewLineCr,
        NewLineLf = PatternOptions.NewLineLf,
        NewLineCrLf = PatternOptions.NewLineCrLf,
        NewLineAny = PatternOptions.NewLineAny,
        NewLineAnyCrLf = PatternOptions.NewLineAnyCrLf,

        BackslashRAnyCrLf = PatternOptions.BsrAnyCrLf,
        BackslashRUnicode = PatternOptions.BsrUnicode,

        NoStartOptimize = PatternOptions.NoStartOptimize,

        PartialSoft = PatternOptions.PartialSoft,
        PartialHard = PatternOptions.PartialHard,

        ShortestMatch = PatternOptions.DfaShortest
    }
}
