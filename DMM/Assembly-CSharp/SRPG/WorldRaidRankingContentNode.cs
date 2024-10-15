// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRankingContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D71")]
  public class WorldRaidRankingContentNode : ContentNode
  {
    [Token(Token = "0x400E281")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray mRankingImages;
    [Token(Token = "0x400E282")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mRankingTextObj;
    [Token(Token = "0x400E283")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mRankingText;
    [Token(Token = "0x400E284")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mUserNameTxt;
    [Token(Token = "0x400E285")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mUserLevelTxt;
    [Token(Token = "0x400E286")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mScoreTxt;
    [Token(Token = "0x400E287")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mGuildNameTxt;
    [Token(Token = "0x400E288")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mGuildNoneObj;
    [Token(Token = "0x400E289")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private AwardItem mAwardItem;

    [Token(Token = "0x600D3E0")]
    [Address(RVA = "0x9E93B0", Offset = "0x9E81B0", VA = "0x109E93B0")]
    public void Setup(WorldRaidRankingData ranking_data)
    {
    }

    [Token(Token = "0x600D3E1")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public WorldRaidRankingContentNode()
    {
    }
  }
}
