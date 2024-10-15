// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalRarityCheckContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20022C8")]
  public class CrystalRarityCheckContent : MonoBehaviour
  {
    [Token(Token = "0x4009AED")]
    private const string SBV_KEY_CRYSTAL_ICON = "SBV_KEY_CRYSTAL_ICON";
    [Token(Token = "0x4009AEE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray RankImageArray;
    [Token(Token = "0x4009AEF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4009AF0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SerializeValueBehaviour Content;

    [Token(Token = "0x6009566")]
    [Address(RVA = "0x583A30", Offset = "0x582830", VA = "0x10583A30")]
    private void Awake()
    {
    }

    [Token(Token = "0x6009567")]
    [Address(RVA = "0x583A80", Offset = "0x582880", VA = "0x10583A80")]
    public void Setup(int rarity, List<CrystalData> crystal_datas)
    {
    }

    [Token(Token = "0x6009568")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CrystalRarityCheckContent()
    {
    }
  }
}
