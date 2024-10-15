// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestRewardMineInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200284C")]
  public class PointQuestRewardMineInfo : MonoBehaviour
  {
    [Token(Token = "0x400C048")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mUnitIcon;
    [Token(Token = "0x400C049")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mUserLevelText;
    [Token(Token = "0x400C04A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x400C04B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BitmapText mPointCountText;

    [Token(Token = "0x600B5E2")]
    [Address(RVA = "0x7C0870", Offset = "0x7BF670", VA = "0x107C0870")]
    public void Setup()
    {
    }

    [Token(Token = "0x600B5E3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PointQuestRewardMineInfo()
    {
    }
  }
}
