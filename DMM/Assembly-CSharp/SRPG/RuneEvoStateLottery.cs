﻿// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEvoStateLottery
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A3")]
  [AddComponentMenu("UI/Rune/RuneEvoStateLottery")]
  internal class RuneEvoStateLottery : MonoBehaviour
  {
    [Token(Token = "0x400C993")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private LText StatusType;
    [Token(Token = "0x400C994")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text StatusMin;
    [Token(Token = "0x400C995")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text StatusMax;

    [Token(Token = "0x600BCED")]
    [Address(RVA = "0x849260", Offset = "0x848060", VA = "0x10849260")]
    public void SetLotteryText(RuneLotteryEvoState runeLotteryEvoState)
    {
    }

    [Token(Token = "0x600BCEE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneEvoStateLottery()
    {
    }
  }
}