## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,1
       je        near ptr M00_L04
       cmp       rbx,2
       je        short M00_L04
       lea       rdi,[rbx+0FFFE]
       cmp       rdi,1
       je        short M00_L00
       cmp       rdi,2
       je        short M00_L00
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       mov       rbp,rax
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       add       rbp,rax
       jmp       short M00_L01
M00_L00:
       mov       ebp,1
M00_L01:
       dec       rbx
       cmp       rbx,1
       je        short M00_L02
       cmp       rbx,2
       je        short M00_L02
       lea       rdx,[rbx+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       mov       rdi,rax
       lea       rdx,[rbx+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       add       rax,rdi
       jmp       short M00_L03
M00_L02:
       mov       eax,1
M00_L03:
       add       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```

## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M00_L02
       cmp       rbx,1
       je        short M00_L01
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       rdx,rbx
       call      qword ptr [7FFF8315E010]
       test      rax,rax
       je        short M00_L00
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       lea       rdx,[rbx+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E2E0]
       mov       rdi,rax
       lea       rdx,[rbx+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E2E0]
       add       rdi,rax
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFF8315E100]
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].FindValue(UInt64)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,rsi
       shr       rcx,20
       xor       ecx,esi
       mov       edx,ecx
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rax+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       mov       r11,[rbx+10]
       xor       r8d,r8d
       dec       edx
       mov       r10d,[r11+8]
M01_L00:
       cmp       r10d,edx
       jbe       short M01_L05
       mov       eax,edx
       lea       rax,[rax+rax*2]
       lea       rbp,[r11+rax*8+10]
       cmp       [rbp],ecx
       jne       short M01_L06
       cmp       [rbp+8],rsi
       jne       short M01_L06
M01_L01:
       lea       rax,[rbp+10]
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L05
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[rbx+rdx*8+10]
       cmp       [rbp],r14d
       je        short M01_L08
M01_L04:
       mov       edx,[rbp+4]
       inc       r15d
       cmp       r13d,r15d
       jae       short M01_L03
       jmp       near ptr M01_L09
M01_L05:
       xor       eax,eax
       jmp       short M01_L02
M01_L06:
       mov       edx,[rbp+4]
       inc       r8d
       cmp       r10d,r8d
       jae       short M01_L00
       jmp       short M01_L09
M01_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FFF83000470
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L10
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       rbx,[rbx+10]
       xor       r15d,r15d
       dec       edx
       jmp       near ptr M01_L03
M01_L08:
       mov       rdx,[rbp+8]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FFF83000478
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFF8315F420]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       xor       eax,eax
       mov       ecx,1
       mov       r8d,2
       cmp       rdx,2
       jb        short M00_L03
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L00:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jbe       short M00_L02
M00_L01:
       ret
M00_L02:
       mov       r9,rax
       mov       rax,rcx
       mov       rcx,r9
       jmp       short M00_L00
M00_L03:
       mov       rax,rcx
       jmp       short M00_L01
; Total bytes of code 60
```

## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       cmp       rbx,1
       je        near ptr M00_L04
       cmp       rbx,2
       je        short M00_L04
       lea       rdi,[rbx+0FFFE]
       cmp       rdi,1
       je        short M00_L02
       cmp       rdi,2
       je        short M00_L02
       lea       rdx,[rdi+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E208]
       mov       rbp,rax
       lea       rdx,[rdi+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E208]
       add       rbp,rax
M00_L00:
       dec       rbx
       cmp       rbx,1
       je        short M00_L03
       cmp       rbx,2
       je        short M00_L03
       lea       rdx,[rbx+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E208]
       mov       rdi,rax
       lea       rdx,[rbx+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8315E208]
       add       rax,rdi
M00_L01:
       add       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ebp,1
       jmp       short M00_L00
M00_L03:
       mov       eax,1
       jmp       short M00_L01
M00_L04:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 165
```

## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M00_L02
       cmp       rbx,1
       je        short M00_L01
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       rdx,rbx
       call      qword ptr [7FFF8314DFF8]
       test      rax,rax
       je        short M00_L00
       mov       rax,[rax]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       lea       rdx,[rbx+0FFFF]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       mov       rdi,rax
       lea       rdx,[rbx+0FFFE]
       mov       rcx,rsi
       call      qword ptr [7FFF8314E2E0]
       add       rdi,rax
       mov       rcx,[rsi+8]
       cmp       [rcx],cl
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFF8314E0E8]
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 145
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.UInt64, System.Private.CoreLib],[System.UInt64, System.Private.CoreLib]].FindValue(UInt64)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M01_L05
       mov       rdi,[rbx+18]
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,rsi
       shr       rcx,20
       xor       ecx,esi
       mov       edx,ecx
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r11d,[rax+8]
       mov       r8d,r11d
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,r11d
       jae       near ptr M01_L10
       mov       edx,edx
       lea       rax,[rax+rdx*4+10]
       mov       edx,[rax]
       mov       r11,[rbx+10]
       xor       r8d,r8d
       dec       edx
       mov       r10d,[r11+8]
M01_L00:
       cmp       r10d,edx
       jbe       short M01_L05
       mov       eax,edx
       lea       rax,[rax+rax*2]
       lea       rbp,[r11+rax*8+10]
       cmp       [rbp],ecx
       jne       short M01_L06
       cmp       [rbp+8],rsi
       jne       short M01_L06
M01_L01:
       lea       rax,[rbp+10]
M01_L02:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       r13d,[rbx+8]
       cmp       r13d,edx
       jbe       short M01_L05
       mov       edx,edx
       lea       rdx,[rdx+rdx*2]
       lea       rbp,[rbx+rdx*8+10]
       cmp       [rbp],r14d
       je        short M01_L08
M01_L04:
       mov       edx,[rbp+4]
       inc       r15d
       cmp       r13d,r15d
       jae       short M01_L03
       jmp       near ptr M01_L09
M01_L05:
       xor       eax,eax
       jmp       short M01_L02
M01_L06:
       mov       edx,[rbp+4]
       inc       r8d
       cmp       r10d,r8d
       jae       short M01_L00
       jmp       short M01_L09
M01_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r11,7FFF82FF0470
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rdx,[rbx+8]
       mov       ecx,r14d
       imul      rcx,[rbx+30]
       shr       rcx,20
       inc       rcx
       mov       r8d,[rdx+8]
       imul      rcx,r8
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       short M01_L10
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edx,[rdx]
       mov       rbx,[rbx+10]
       xor       r15d,r15d
       dec       edx
       jmp       near ptr M01_L03
M01_L08:
       mov       rdx,[rbp+8]
       mov       rcx,rdi
       mov       r8,rsi
       mov       r11,7FFF82FF0478
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       near ptr M01_L04
M01_L09:
       call      qword ptr [7FFF8314F420]
       int       3
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 350
```

## .NET Core 9.0.6 (CoreCLR 9.0.625.26613, CoreFX 9.0.625.26613), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       xor       eax,eax
       mov       ecx,1
       mov       r8d,2
       cmp       rdx,2
       jb        short M00_L03
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M00_L00:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jbe       short M00_L02
M00_L01:
       ret
M00_L02:
       mov       r9,rax
       mov       rax,rcx
       mov       rcx,r9
       jmp       short M00_L00
M00_L03:
       mov       rax,rcx
       jmp       short M00_L01
; Total bytes of code 60
```

