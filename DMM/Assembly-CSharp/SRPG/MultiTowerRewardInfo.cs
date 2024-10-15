// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027AE")]
  [AddComponentMenu("UI/MultiTowerRewardInfo")]
  public class MultiTowerRewardInfo : MonoBehaviour
  {
    [Token(Token = "0x400BBAC")]
    [FieldOffset(Offset = "0xC")]
    public GameObject unitObj;
    [Token(Token = "0x400BBAD")]
    [FieldOffset(Offset = "0x10")]
    public GameObject itemObj;
    [Token(Token = "0x400BBAE")]
    [FieldOffset(Offset = "0x14")]
    public GameObject amountObj;
    [Token(Token = "0x400BBAF")]
    [FieldOffset(Offset = "0x18")]
    public GameObject artifactObj;
    [Token(Token = "0x400BBB0")]
    [FieldOffset(Offset = "0x1C")]
    public GameParameter iconParam;
    [Token(Token = "0x400BBB1")]
    [FieldOffset(Offset = "0x20")]
    public GameParameter frameParam;
    [Token(Token = "0x400BBB2")]
    [FieldOffset(Offset = "0x24")]
    public RawImage itemTex;
    [Token(Token = "0x400BBB3")]
    [FieldOffset(Offset = "0x28")]
    public Image frameTex;
    [Token(Token = "0x400BBB4")]
    [FieldOffset(Offset = "0x2C")]
    public Texture coinTex;
    [Token(Token = "0x400BBB5")]
    [FieldOffset(Offset = "0x30")]
    public Texture goldTex;
    [Token(Token = "0x400BBB6")]
    [FieldOffset(Offset = "0x34")]
    public Sprite coinBase;
    [Token(Token = "0x400BBB7")]
    [FieldOffset(Offset = "0x38")]
    public Sprite goldBase;
    [Token(Token = "0x400BBB8")]
    [FieldOffset(Offset = "0x3C")]
    public Text rewardName;
    [Token(Token = "0x400BBB9")]
    [FieldOffset(Offset = "0x40")]
    public Text rewardFloor;
    [Token(Token = "0x400BBBA")]
    [FieldOffset(Offset = "0x44")]
    public RectTransform pos;
    [Token(Token = "0x400BBBB")]
    [FieldOffset(Offset = "0x48")]
    public Text rewardDetailName;
    [Token(Token = "0x400BBBC")]
    [FieldOffset(Offset = "0x4C")]
    public Text rewardDetailInfo;
    [Token(Token = "0x400BBBD")]
    [FieldOffset(Offset = "0x50")]
    public GameObject amountOther;
    [Token(Token = "0x400BBBE")]
    [FieldOffset(Offset = "0x54")]
    public Text amountCount;
    [Token(Token = "0x400BBBF")]
    [FieldOffset(Offset = "0x58")]
    public bool amountDisp;
    [Token(Token = "0x400BBC0")]
    [FieldOffset(Offset = "0x5C")]
    public Text Artifactamount;

    [Token(Token = "0x600B230")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B231")]
    [Address(RVA = "0x765060", Offset = "0x763E60", VA = "0x10765060")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B232")]
    [Address(RVA = "0x765070", Offset = "0x763E70", VA = "0x10765070")]
    private void SetData()
    {
    }

    [Token(Token = "0x600B233")]
    [Address(RVA = "0x764C60", Offset = "0x763A60", VA = "0x10764C60")]
    public void OnDetailClick()
    {
    }

    [Token(Token = "0x600B234")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiTowerRewardInfo()
    {
    }
  }
}
