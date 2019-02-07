!#1323
!#CS_ARCH_ARM, CS_MODE_THUMB, CS_OPT_DETAIL
0x70,0x47,0x00 = bx lr | 1 | lr | READ | lr | pc | | thumb jump
!#1317
!#CS_ARCH_ARM, CS_MODE_THUMB, CS_OPT_DETAIL
0xd0,0xe8,0x11,0xf0 = tbh [r0, r1, lsl #1] | 1 | MEM | r0 | r1 | 0x1 | READ | 2 1 | r0 r1 | thumb2 jump
!#1308
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0x83,0x3d,0xa1,0x75,0x21,0x00,0x04 = cmp dword ptr [rip + 0x2175a1], 4 | 0x00 0x00 0x00 0x00 | 0x83 0x00 0x00 0x00 | 0x0 | 8 | 0x3d | 0x2175a1 | 0x0 | 1 | 0x4 | 2 | MEM | rip | 0x2175a1 | 4 | READ | 0x4 | 4 | rip | rflags | MOD_AF MOD_CF MOD_SF MOD_ZF MOD_PF MOD_OF
!#1262
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0x0f,0x95,0x44,0x24,0x5e = setne byte ptr [rsp + 0x5e] | 0x00 0x00 0x00 0x00 | 0x0f 0x95 0x00 0x00 | 0x0 | 8 | 0x44 | 0x5e | 0x24 | rsp | 1 | 1 | MEM | rsp | 0x5e | 1 | WRITE | rflags rsp
!#1262
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0x0f,0x94,0x44,0x24,0x1f = sete byte ptr [rsp + 0x1f] | 0x00 0x00 0x00 0x00 | 0x0f 0x94 0x00 0x00 | 0x0 | 8 | 0x44 | 0x1f | 0x24 | rsp | 1 | 1 | MEM | rsp | 0x1f | 1 | WRITE | rflags rsp
!#1255
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0xdb,0x7c,0x24,0x40 = fstp xword ptr [rsp + 0x40] | 0x00 0x00 0x00 0x00 | 0xdb 0x00 0x00 0x00 | 0x0 | 8 | 0x7c | 0x40 | 0x24 | rsp | 1 | 1 | MEM | rsp | 0x40 | 10 | WRITE | rsp | fpsw | MOD_C1 UNDEF_C0 UNDEF_C2 UNDEF_C3 | fpu
!#1255
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0xdd,0xd9 = fstp st(1) | 0x00 0x00 0x00 0x00 | 0xdd 0x00 0x00 0x00 | 0x0 | 8 | 0xd9 | 0x0 | 0x0 
 1 | st(1) | 10 | WRITE | fpsw st(1) | MOD_CF PRIOR_SF PRIOR_AF PRIOR_PF
!#1255
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0xdf,0x7c,0x24,0x68 = fistp qword ptr [rsp + 0x68] | 0x00 0x00 0x00 0x00 | 0xdf 0x00 0x00 0x00 | 0x0 | 8 | 0x7c | 0x68 | 0x24 | rsp | 1 | 1 | MEM | rsp | 0x68 | 8 | WRITE | rsp | fpsw | RESET_C1 UNDEF_C0 UNDEF_C2 UNDEF_C3 | fpu
!#1221
!#CS_ARCH_SPARC, CS_MODE_BIG_ENDIAN, None
0x55,0x48,0x89,0xe5 = call 0x55222794
!#1144
!#CS_ARCH_ARM64, CS_MODE_LITTLE_ENDIAN, None
0x00,0x00,0x02,0xb6,0x00,0x00,0x04,0xb6,0x00,0x00,0x02,0xb7,0x00,0x00,0x04,0xb7 = tbz x0, #0x20, #0x4000;tbz x0, #0x20, #0xffffffffffff8004;tbnz x0, #0x20, #0x4008;tbnz x0, #0x20, #0xffffffffffff800c
!#826
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x0b,0x00,0x00,0x0a = beq #0x34 | 1 | 0x34 | 1 | pc | pc | branch_relative arm jump
!#1047
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x48,0x83,0xe4,0xf0 = andq $0xfffffffffffffff0, %rsp
!#959
!#CS_ARCH_X86, CS_MODE_32, None
0xa0,0x28,0x57,0x88,0x7c = mov al, byte ptr[0x7c885728]
!#950
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x66,0xa3,0x94,0x90,0x04,0x08 =  mov word ptr [0x8049094], ax | 0x00 0x00 0x66 0x00 | 0xa3 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x8049094 | 0x0 | 2 | MEM | 0x8049094 | 2 | WRITE | ax | 2 | READ | ax
!#938
!#CS_ARCH_MIPS, CS_MODE_MIPS64 | CS_MODE_LITTLE_ENDIAN, None
0x70,0x00,0xb2,0xff = sd $s2, 0x70($sp)
!#915
!#CS_ARCH_X86, CS_MODE_64, None
0xf0,0x0f,0x1f,0x00 = lock nop dword ptr [rax]
!#913
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x04,0x10,0x9d,0xe4 = pop {r1} | 1 | r1 | WRITE | True | sp | sp r1 | arm
!#884
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x64,0x48,0x03,0x04,0x25,0x00,0x00,0x00,0x00 = addq %fs:0, %rax
!#872
!#CS_ARCH_X86, CS_MODE_32, None
0xf2,0xeb,0x3e = bnd jmp 0x41
!#861
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x01,0x81,0xa0,0xfc = stc2 p1, c8, [r0], #4 | 4 | 1 | 8 | MEM | r0 | READ | 0x4 | True | r0 | r0 | prev8
!#852
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x64,0xa3,0x00,0x00,0x00,0x00 = mov	dword ptr fs:[0], eax | 0x00 0x64 0x00 0x00 | 0xa3 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 2 | MEM | fs | 4 | WRITE | eax | 4 | READ | fs eax
!#825
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x0e,0xf0,0xa0,0xe1 = mov pc, lr | 2 | pc | WRITE | lr | READ | lr | pc | arm
!#813
!#CS_ARCH_ARM, CS_MODE_ARM | CS_MODE_THUMB | CS_MODE_BIG_ENDIAN, None
0xF6,0xC0,0x04,0x01 = movt r4, #0x801
!#809
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_DETAIL
0x0f,0x29,0x8d,0xf0,0xfd,0xff,0xff = movaps xmmword ptr [rbp - 0x210], xmm1 | 0x00 0x00 0x00 0x00 | 0x0f 0x29 0x00 0x00 | 0x0 | 8 | 0x8d | 0xfffffffffffffdf0 | 0x0 | 2 | MEM | rbp | 0xfffffffffffffdf0 | 16 | WRITE | xmm1 | 16 | READ | rbp xmm1 | sse1
!#807
!#CS_ARCH_X86, CS_MODE_64, None
0x4c,0x0f,0x00,0x80,0x16,0x76,0x8a,0xfe = sldt word ptr [rax - 0x17589ea]
!#806
!#CS_ARCH_X86, CS_MODE_64, None
0x0f,0x35 = sysexit
!#805
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x48,0x4c,0x0f,0xb5,0x80,0x16,0x76,0x8a,0xfe = movb	$0x80, %bpl
!#804
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x66,0x48,0xf3,0xd1,0xc0 = rol $1, %ax
!#789
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x8e,0x1e = movw 0(%rsi), %ds
!#767
!#CS_ARCH_ARM, CS_MODE_THUMB, CS_OPT_DETAIL
0xb1,0xe8,0xfc,0x07 = ldm.w	r1!, {r2, r3, r4, r5, r6, r7, r8, sb, sl} | 10 | r1 | READ WRITE | r2 | WRITE | r3 | WRITE | r4 | WRITE | r5 | WRITE | r6 | WRITE | r7 | WRITE | r8 | WRITE | sb | WRITE | sl | WRITE | True | r1 | r1 r2 r3 r4 r5 r6 r7 r8 sb sl | thumb2
!#760
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x02,0x80,0xbd,0xe8 = pop {r1, pc} | 2 | r1 | WRITE | pc | WRITE | sp | sp r1 pc | arm
!#750
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x0e,0x00,0x20,0xe9 = stmdb	r0!, {r1, r2, r3} | 4 | r0 | READ WRITE | r1 | READ | r2 | READ | r3 | READ | True | r0 r1 r2 r3 | r0 | arm 
!#747
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x0e,0x00,0xb0,0xe8 = ldm r0!, {r1, r2, r3} | 4 | r0 | READ WRITE | r1 | WRITE | r2 | WRITE | r3 | WRITE | True | r0 | r0 r1 r2 r3 | arm
!#747
!#CS_ARCH_ARM, CS_MODE_THUMB, CS_OPT_DETAIL
0x0e,0xc8 =  ldm r0!, {r1, r2, r3} | 4 | r0 | READ WRITE | r1 | WRITE | r2 | WRITE | r3 | WRITE | True | r0 | r0 r1 r2 r3 | arm
!#746
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x89,0x00,0x2d,0xe9 = push {r0, r3, r7} | 3 | r0 | READ WRITE | r3 | READ WRITE | r7 | READ WRITE | sp r0 r3 r7 | sp | arm
!#744
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0x02,0x80,0xbd,0xe8 = pop {r1, pc} | 2 | r1 | WRITE | pc | WRITE | sp | sp r1 pc | arm
!#741
!#CS_ARCH_X86, CS_MODE_32, None
0x83,0xff,0xf7 = cmp edi, -9
!#717
!#CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x48,0x8b,0x04,0x25,0x00,0x00,0x00,0x00 = movq 0, %rax
!#711
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xa3,0x44,0xb0,0x00,0x10 = mov dword ptr [0x1000b044], eax | 0x00 0x00 0x00 0x00 | 0xa3 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x1000b044 | 0x0 | 2 | MEM | 0x1000b044 | 4 | WRITE | eax | 4 | READ | eax
!#613
!#CS_ARCH_X86, CS_MODE_64, None
0xd9,0x74,0x24,0xd8 = fnstenv [rsp - 0x28]
!#CS_ARCH_X86, CS_MODE_64, None
0xd9,0x64,0x24,0xd8 = fldenv [rsp-0x28]
!#554
!#CS_ARCH_X86, CS_MODE_32, None
0xe7,0x84 = out 0x84, eax
!#554
!#CS_ARCH_X86, CS_MODE_32, None
0xe5,0x8c = in eax, 0x8c
!#545
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x95 = xchg	eax, ebp | 0x00 0x00 0x00 0x00 | 0x95 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 2 | eax | 4 | READ WRITE | ebp | 4 | READ WRITE | eax ebp | eax ebp | not64bitmode
!#544
!#CS_ARCH_X86, CS_MODE_32, None
0xdf,0x30 = fbstp tbyte ptr [eax]
!#544
!#CS_ARCH_X86, CS_MODE_32, None
0xdf,0x20 = fbld tbyte ptr [eax]
!#541
!#CS_ARCH_X86, CS_MODE_64, None
0x48,0xb8,0x00,0x00,0x00,0x00,0x80,0xf8,0xff,0xff = movabs rax, 0xfffff88000000000
!#499
!#CS_ARCH_X86, CS_MODE_64, None
0x48,0xb8,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x80 = movabs rax, 0x8000000000000000
!#492
!#CS_ARCH_X86, CS_MODE_32, None
0xff,0x18,0xff,0x28,0x0f,0xae,0x04,0x24,0x0f,0xae,0x0c,0x24 = lcall [eax];ljmp [eax];fxsave [esp];fxrstor [esp]
!#470
!#CS_ARCH_X86, CS_MODE_32, None
0x0f,0x01,0x05,0xa0,0x90,0x04,0x08,0x0f,0x01,0x0d,0xa7,0x90,0x04,0x08,0x0f,0x01,0x15,0xa0,0x90,0x04,0x08,0x0f,0x01,0x1d,0xa7,0x90,0x04,0x08 = sgdt [0x80490a0];sidt [0x80490a7];lgdt [0x80490a0];lidt [0x80490a7]
!#459
!#CS_ARCH_ARM, CS_MODE_ARM, CS_OPT_DETAIL
0xd3,0x20,0x11,0xe1 = ldrsb r2, [r1, -r3] | 2 | r2 | WRITE | MEM | r1 | r3 | -1 | True | r1 r3 | r2 | arm
!#456
!#CS_ARCH_X86, CS_MODE_16, None
0xe8,0x35,0x64,0xe9,0x35,0x64,0x66,0xe9,0x35,0x64,0x93,0x53,0x66,0xe8,0x35,0x64,0x93,0x53,0x66,0xe9,0x35,0x64,0x93,0x53 = call 0x6438;jmp 0x643b;jmp 0x53936441;call 0x53936447;jmp 0x5393644d 
!#456
!#CS_ARCH_X86, CS_MODE_32, None
0x66,0xe8,0x35,0x64,0xe9,0x35,0x64,0x93,0x53,0x66,0xe8,0x35,0x64,0x66,0xe9,0x35,0x64 = call 0x6439;jmp 0x5393643e;call 0x6442;jmp 0x6446
!#458
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xA1,0x12,0x34,0x90,0x90 =  mov eax, dword ptr [0x90903412] | 0x00 0x00 0x00 0x00 | 0xa1 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x90903412 | 0x0 | 2 | eax | 4 | WRITE | MEM | 0x90903412 | 4 | READ | eax
!#454
!#CS_ARCH_X86, CS_MODE_32, None
0xf2,0x6c,0xf2,0x6d,0xf2,0x6e,0xf2,0x6f,0xf2,0xac,0xf2,0xad = repne insb byte ptr es:[edi], dx;repne insd dword ptr es:[edi], dx;repne outsb dx, byte ptr [esi];repne outsd dx, dword ptr [esi];repne lodsb al, byte ptr [esi];repne lodsd eax, dword ptr [esi]
!#450
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xff,0x2d,0x34,0x35,0x23,0x01 = ljmp [0x1233534] | 0x00 0x00 0x00 0x00 | 0xff 0x00 0x00 0x00 | 0x0 | 4 | 0x2d | 0x1233534 | 0x0 | 1 | MEM | 0x1233534 | 6 | jump
!#448
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xea,0x12,0x34,0x56,0x78,0x9a,0xbc = ljmp 0xbc9a:0x78563412 | 0x00 0x00 0x00 0x00 | 0xea 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 2 | 0xbc9a | 0x78563412 | 2 | 0xbc9a | 2 | 0x78563412 | 4 | not64bitmode jump
!#426
!#CS_ARCH_SPARC, CS_MODE_BIG_ENDIAN, None
0xbb,0x70,0x00,0x00 = popc %g0, %i5
!#358
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xe8,0xe3,0xf6,0xff,0xff = call	0xfffffffffffff6e8 | 0x00 0x00 0x00 0x00 | 0xe8 0x00 0x00 0x00 | 0x0 | 8 | 0x0 | 0x0 | 0x0 | 1 | 0xfffffffffffff6e8 | 1 | 0xfffffffffffff6e8 | 8 | rsp rip | rsp | call branch_relative mode64
!#353
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xe6,0xa2 = out 0xa2, al | 0x00 0x00 0x00 0x00 | 0xe6 0x00 0x00 0x00 | 0x0 | 8 | 0x0 | 0x0 | 0x0 | 1 | 0xa2 | 2 | 0xa2 | 8 | al | 1 | READ | al
!#305
!#CS_ARCH_X86, CS_MODE_32, None
0x34,0x8b = xor	al, 0x8b
!#298
!#CS_ARCH_X86, CS_MODE_32, None
0xf3,0x90,0x66,0xf3,0xf2,0x0f,0x59,0xff,0xf2,0x66,0x0f,0x59,0xff = pause;mulsd xmm7, xmm7;mulpd xmm7, xmm7
!#294
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xc1,0xe6,0x08 = shl esi, 8 | 0x00 0x00 0x00 0x00 | 0xc1 0x00 0x00 0x00 | 0x0 | 4 | 0xe6 | 0x0 | 0x0 | 1 | 0x8 | 2 | esi | 4 | READ WRITE | 0x8 | 1 | esi | eflags esi | MOD_CF MOD_SF MOD_ZF MOD_PF MOD_OF UNDEF_AF
!#285
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x3c,0x12,0x80 = cmp al, 0x12 | 0x00 0x00 0x00 0x00 | 0x3c 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 1 | 0x12 | 2 | al | 1 | READ | 0x12 | 1 | al | eflags | MOD_AF MOD_CF MOD_SF MOD_ZF MOD_PF MOD_OF
!#265
!#CS_ARCH_ARM, CS_MODE_THUMB, CS_OPT_DETAIL
0x52,0xf8,0x23,0x30 = ldr.w r3, [r2, r3, lsl #2] | 2 | r3 | WRITE | MEM | r2 | r3 | READ | 2 2 | r2 r3 | r3 | thumb2
!#264
!#CS_ARCH_ARM, CS_MODE_THUMB, None
0x0c,0xbf,0x17,0x20,0x4f,0xf0,0xff,0x30 = ite eq;moveq r0, #0x17;movne.w r0, #-1
!#246
!#CS_ARCH_ARM, CS_MODE_THUMB, None
0x52,0xf8,0x23,0xf0 = ldr.w pc, [r2, r3, lsl #2] | 2 | pc | WRITE | MEM | r2 | r3 | READ | 2 2 | r2 r3 | pc | thumb2
!#232
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x8e,0x10 = mov ss, word ptr [eax] | 0x00 0x00 0x00 0x00 | 0x8e 0x00 0x00 0x00 | 0x0 | 4 | 0x10 | 0x0 | 0x0 | 2 | ss | 2 | WRITE | MEM | eax | 2 | READ | eax | ss | privilege
!#231
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x66,0x6b,0xc0,0x02 = imul ax, ax, 2 | 0x00 0x00 0x66 0x00 | 0x6b 0x00 0x00 0x00 | 0x0 | 4 | 0xc0 | 0x0 | 0x0 | 1 | 0x2 | 3 | ax | 2 | WRITE | ax | 2 | READ | 0x2 | 2 | ax | eflags ax | MOD_CF MOD_SF MOD_OF UNDEF_ZF UNDEF_PF UNDEF_AF
!#230
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0xec = in al, dx | 0x00 0x00 0x00 0x00 | 0xec 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 2 | al | 1 | WRITE | dx | 2 | READ | dx | al
!#229
!#CS_ARCH_X86, CS_MODE_32, CS_OPT_DETAIL
0x0e, push cs | 0x00 0x00 0x00 0x00 | 0x0e 0x00 0x00 0x00 | 0x0 | 4 | 0x0 | 0x0 | 0x0 | 1 | cs | 2 | not64bitmode
!#213
!#CS_ARCH_X86, CS_MODE_16, None
0xea,0xaa,0xff,0x00,0xf0 = ljmp 0xf000:0xffaa
!#191
!#CS_ARCH_X86, CS_MODE_64, None
0xc5,0xe8,0xc2,0x33,0x9b = vcmpps xmm6, xmm2, xmmword ptr [rbx], 0x9b
!#176
!#CS_ARCH_ARM, CS_MODE_ARM, None
0xfd,0xff,0xff,0x1a = bne #0xfffffffc
!#151
!#CS_ARCH_X86, CS_MODE_64, None
0x4d,0x8d,0x3d,0x02,0x00,0x00,0x00,0xeb,0xb0 = lea r15, [rip + 2];jmp 0xffffffffffffffb9
!#134
!#CS_ARCH_ARM, CS_MODE_ARM | CS_MODE_BIG_ENDIAN, CS_OPT_DETAIL
0xe7,0x92,0x11,0x80 = ldr r1, [r2, r0, lsl #3] | 2 | r1 | WRITE | MEM | r2 | r0 | READ | 2 3 | r2 r0 | r1 | arm
!#133
!#CS_ARCH_ARM, CS_MODE_ARM | CS_MODE_BIG_ENDIAN, CS_OPT_DETAIL
0xed,0xdf,0x2b,0x1b = vldr d18, [pc, #0x6c] | 2 | d18 | WRITE | MEM | pc | 0x6c | READ | pc | d18 | vfp2
!#132
!#CS_ARCH_ARM, CS_MODE_ARM | CS_MODE_THUMB | CS_MODE_BIG_ENDIAN, CS_OPT_DETAIL
0x49,0x19 = ldr r1, [pc, #0x64] | 2 | r1 | WRITE | MEM | pc | 0x64 | READ | pc | r1 | thumb thumb1only
!#130
!#CS_ARCH_ARM, CS_MODE_ARM | CS_MODE_BIG_ENDIAN, CS_OPT_DETAIL
0xe1,0xa0,0xf0,0x0e = mov pc, lr | 2 | pc | WRITE | lr | READ | lr | pc | arm
!#85
!#CS_ARCH_ARM64, CS_MODE_LITTLE_ENDIAN, None
0xee,0x3f,0xbf,0x29 = stp w14, w15, [sp, #-8]!
!#82
!#CS_ARCH_X86, CS_MODE_64, None
0xf2,0x66,0xaf = repne scasw ax, word ptr [rdi]
!#35
!#CS_ARCH_X86, CS_MODE_32, None
0xe8,0xc6,0x02,0x00,0x00 = call 0x2cb
!#8
!#CS_ARCH_X86, CS_MODE_32, None
0xff,0x8c,0xf9,0xff,0xff,0x9b,0xf9 = dec dword ptr [ecx + edi*8 - 0x6640001]
!#29
!#CS_ARCH_ARM64, CS_MODE_LITTLE_ENDIAN, None
0x00,0x00,0x00,0x4c = st4 {v0.16b, v1.16b, v2.16b, v3.16b}, [x0]