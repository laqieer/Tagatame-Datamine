// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028EF")]
  [AddComponentMenu("UI/Raid/RaidRewardListWindow")]
  public class RaidRewardListWindow : MonoBehaviour
  {
    [Token(Token = "0x400C4D4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RaidRewardIcon mRaidRewardIconTemplate;
    [Token(Token = "0x400C4D5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mRaidRewardIconParent;

    [Token(Token = "0x600B94A")]
    [Address(RVA = "0x80B800", Offset = "0x80A600", VA = "0x1080B800")]
    private void Start()
    {
    }

    [Token(Token = "0x600B94B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RaidRewardListWindow()
    {
    }
  }
}
