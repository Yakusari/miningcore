/*
Copyright 2017 - 2020 Coin Foundry (coinfoundry.org)
Copyright 2020 - 2021 AlphaX Projects (alphax.pro)
Authors: Oliver Weichhold (oliver@weichhold.com)
         Olaf Wasilewski (olaf.wasilewski@gmx.de)
         
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
associated documentation files (the "Software"), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Runtime.InteropServices;

namespace Miningcore.Native
{
    public static unsafe class LibNewhash
    {
        [DllImport("libnewhash", EntryPoint = "ghostrider_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ghostrider(byte* input, void* output, uint inputLength);
        
        [DllImport("libnewhash", EntryPoint = "heavyhash_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int heavyhash(byte* input, void* output, uint inputLength);
        
        [DllImport("libnewhash", EntryPoint = "minotaur_export", CallingConvention = CallingConvention.Cdecl)]
        public static extern int minotaur(byte* input, void* output, uint inputLength);
    }
}
