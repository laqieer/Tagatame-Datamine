// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDrawDisassemblyInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002985")]
  [AddComponentMenu("UI/Rune/RuneDrawDisassemblyInfo")]
  public class RuneDrawDisassemblyInfo : MonoBehaviour
  {
    [Token(Token = "0x400C87D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mTextZeny;
    [Token(Token = "0x400C87E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mTextSelectedNum;
    [Token(Token = "0x400C87F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mTextSelectedMax;
    [Token(Token = "0x400C880")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mTextRarityWarning;
    [Token(Token = "0x400C881")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject[] mIconObj;
    [Token(Token = "0x400C882")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text[] mIconNum;
    [Token(Token = "0x400C883")]
    [FieldOffset(Offset = "0x24")]
    private int mZeny;
    [Token(Token = "0x400C884")]
    [FieldOffset(Offset = "0x28")]
    private int mSelectedCount;
    [Token(Token = "0x400C885")]
    [FieldOffset(Offset = "0x2C")]
    private int mSelectedMax;
    [Token(Token = "0x400C886")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsRarityWarning;
    [Token(Token = "0x400C887")]
    [FieldOffset(Offset = "0x34")]
    private List<RuneDisassembly.Materials> mDisassemblyData;

    [Token(Token = "0x600BC24")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BC25")]
    [Address(RVA = "0x83D8B0", Offset = "0x83C6B0", VA = "0x1083D8B0")]
    public void SetParam(
      int zeny,
      int selected_count,
      int selected_max,
      bool is_rarity_warning,
      List<RuneDisassembly.Materials> disassembly_data)
    {
    }

    [Token(Token = "0x600BC26")]
    [Address(RVA = "0x83D4E0", Offset = "0x83C2E0", VA = "0x1083D4E0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BC27")]
    [Address(RVA = "0x83D8F0", Offset = "0x83C6F0", VA = "0x1083D8F0")]
    public RuneDrawDisassemblyInfo()
    {
    }
  }
}
