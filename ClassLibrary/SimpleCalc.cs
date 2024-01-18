using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    // [Conclusion]
    // Quick JIT is enabled by default, and JIT may not optimize enough.
    // Adding "<TieredCompilationQuickJit>false</TieredCompilationQuickJit>" to the application's project file disables Quick JIT and also performs inlining.
    public static class SimpleCalc
    {
        public static int Add10(int x, int y)
        {
#if false // for .NET5.0 (not inlined)
[decompiled code]
        return Add(Add(Add(Add(Add(Add(Add(Add(Add(Add(x, y), y), y), y), y), y), y), y), y), y);

[machine language (x64)]
 push        rbp  
 sub         rsp,50h  
 lea         rbp,[rsp+50h]  
 mov         dword ptr [rbp+10h],ecx  
 mov         dword ptr [rbp+18h],edx  
 mov         ecx,dword ptr [rbp+10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-4],eax  
 mov         ecx,dword ptr [rbp-4]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-8],eax  
 mov         ecx,dword ptr [rbp-8]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-0Ch],eax  
 mov         ecx,dword ptr [rbp-0Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-10h],eax  
 mov         ecx,dword ptr [rbp-10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-14h],eax  
 mov         ecx,dword ptr [rbp-14h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-18h],eax  
 mov         ecx,dword ptr [rbp-18h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-1Ch],eax  
 mov         ecx,dword ptr [rbp-1Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-20h],eax  
 mov         ecx,dword ptr [rbp-20h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 mov         dword ptr [rbp-24h],eax  
 mov         ecx,dword ptr [rbp-24h]  
 mov         edx,dword ptr [rbp+18h]  
 call        CLRStub[MethodDescPrestub]@7ffe79c32010 (07FFE79C32010h)  
 nop  
 lea         rsp,[rbp]  
 pop         rbp  
 ret  
#endif
#if false // for .NET6.0 (inlined)
[decompiled code]
        return Add(Add(Add(Add(Add(Add(Add(Add(Add(Add(x, y), y), y), y), y), y), y), y), y), y);

[machine language (x64)]
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 add         ecx,edx  
 lea         eax,[rcx+rdx]  
 add         eax,edx  
 ret
#endif
#if false // for .NET7.0 (not inlined)
[decompiled code]
		return Add(Add(Add(Add(Add(Add(Add(Add(Add(Add(x, y), y), y), y), y), y), y), y), y), y);

[machine language (x64)]
 push        rbp  
 sub         rsp,50h  
 lea         rbp,[rsp+50h]  
 mov         dword ptr [rbp+10h],ecx  
 mov         dword ptr [rbp+18h],edx  
 mov         ecx,dword ptr [rbp+10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-4],eax  
 mov         ecx,dword ptr [rbp-4]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-8],eax  
 mov         ecx,dword ptr [rbp-8]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-0Ch],eax  
 mov         ecx,dword ptr [rbp-0Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-10h],eax  
 mov         ecx,dword ptr [rbp-10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-14h],eax  
 mov         ecx,dword ptr [rbp-14h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-18h],eax  
 mov         ecx,dword ptr [rbp-18h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-1Ch],eax  
 mov         ecx,dword ptr [rbp-1Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-20h],eax  
 mov         ecx,dword ptr [rbp-20h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 mov         dword ptr [rbp-24h],eax  
 mov         ecx,dword ptr [rbp-24h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE7A5712E8 (07FFE7A5712E8h)]  
 nop  
 add         rsp,50h  
 pop         rbp  
#endif
#if false // for .NET8.0 (not inlined)
[decompiled code]
        return Add(Add(Add(Add(Add(Add(Add(Add(Add(Add(x, y), y), y), y), y), y), y), y), y), y);

[machine language (x64)]
 push        rbp  
 sub         rsp,50h  
 lea         rbp,[rsp+50h]  
 mov         dword ptr [rbp+10h],ecx  
 mov         dword ptr [rbp+18h],edx  
 mov         ecx,dword ptr [rbp+10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-4],eax  
 mov         ecx,dword ptr [rbp-4]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-8],eax  
 mov         ecx,dword ptr [rbp-8]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-0Ch],eax  
 mov         ecx,dword ptr [rbp-0Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-10h],eax  
 mov         ecx,dword ptr [rbp-10h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-14h],eax  
 mov         ecx,dword ptr [rbp-14h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-18h],eax  
 mov         ecx,dword ptr [rbp-18h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-1Ch],eax  
 mov         ecx,dword ptr [rbp-1Ch]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-20h],eax  
 mov         ecx,dword ptr [rbp-20h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 mov         dword ptr [rbp-24h],eax  
 mov         ecx,dword ptr [rbp-24h]  
 mov         edx,dword ptr [rbp+18h]  
 call        qword ptr [CLRStub[MethodDescPrestub]@00007FFE8F99D878 (07FFE8F99D878h)]  
 nop  
 add         rsp,50h  
 pop         rbp  
 ret  


#endif
            var z = Add(x, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            z = Add(z, y);
            return z;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining)] // <= The presence or absence of this attribute does not affect the problem
        private static int Add(int x, int y) => x + y;
    }
}
