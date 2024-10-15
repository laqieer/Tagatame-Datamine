// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002761")]
  [AddComponentMenu("UI/Multi/Versus/VersusTowerRewardItem")]
  public class VersusTowerRewardItem : MonoBehaviour
  {
    [Token(Token = "0x400BA21")]
    [FieldOffset(Offset = "0xC")]
    public GameObject unitObj;
    [Token(Token = "0x400BA22")]
    [FieldOffset(Offset = "0x10")]
    public GameObject itemObj;
    [Token(Token = "0x400BA23")]
    [FieldOffset(Offset = "0x14")]
    public GameObject amountObj;
    [Token(Token = "0x400BA24")]
    [FieldOffset(Offset = "0x18")]
    public GameParameter iconParam;
    [Token(Token = "0x400BA25")]
    [FieldOffset(Offset = "0x1C")]
    public GameParameter frameParam;
    [Token(Token = "0x400BA26")]
    [FieldOffset(Offset = "0x20")]
    public RawImage itemTex;
    [Token(Token = "0x400BA27")]
    [FieldOffset(Offset = "0x24")]
    public Image frameTex;
    [Token(Token = "0x400BA28")]
    [FieldOffset(Offset = "0x28")]
    public Texture coinTex;
    [Token(Token = "0x400BA29")]
    [FieldOffset(Offset = "0x2C")]
    public Texture goldTex;
    [Token(Token = "0x400BA2A")]
    [FieldOffset(Offset = "0x30")]
    public Sprite coinBase;
    [Token(Token = "0x400BA2B")]
    [FieldOffset(Offset = "0x34")]
    public Sprite goldBase;
    [Token(Token = "0x400BA2C")]
    [FieldOffset(Offset = "0x38")]
    public Text rewardName;
    [Token(Token = "0x400BA2D")]
    [FieldOffset(Offset = "0x3C")]
    public Text rewardFloor;
    [Token(Token = "0x400BA2E")]
    [FieldOffset(Offset = "0x40")]
    public RectTransform pos;
    [Token(Token = "0x400BA2F")]
    [FieldOffset(Offset = "0x44")]
    public Text rewardDetailName;
    [Token(Token = "0x400BA30")]
    [FieldOffset(Offset = "0x48")]
    public Text rewardDetailInfo;
    [Token(Token = "0x400BA31")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject currentMark;
    [Token(Token = "0x400BA32")]
    [FieldOffset(Offset = "0x50")]
    public GameObject clearMark;
    [Token(Token = "0x400BA33")]
    [FieldOffset(Offset = "0x54")]
    public GameObject current_fil;
    [Token(Token = "0x400BA34")]
    [FieldOffset(Offset = "0x58")]
    public GameObject cleared_fil;
    [Token(Token = "0x400BA35")]
    [FieldOffset(Offset = "0x5C")]
    private VersusTowerRewardItem.REWARD_TYPE mType;
    [Token(Token = "0x400BA36")]
    [FieldOffset(Offset = "0x60")]
    private int mSeasonIdx;

    [Token(Token = "0x600B0BC")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B0BD")]
    [Address(RVA = "0x754D70", Offset = "0x753B70", VA = "0x10754D70")]
    public void Refresh(VersusTowerRewardItem.REWARD_TYPE type = VersusTowerRewardItem.REWARD_TYPE.Arrival, int idx = 0)
    {
    }

    [Token(Token = "0x600B0BE")]
    [Address(RVA = "0x754EB0", Offset = "0x753CB0", VA = "0x10754EB0")]
    public void SetData(VersusTowerRewardItem.REWARD_TYPE type, int idx = 0)
    {
    }

    [Token(Token = "0x600B0BF")]
    [Address(RVA = "0x7548A0", Offset = "0x7536A0", VA = "0x107548A0")]
    public void OnDetailClick()
    {
    }

    [Token(Token = "0x600B0C0")]
    [Address(RVA = "0x756100", Offset = "0x754F00", VA = "0x10756100")]
    public VersusTowerRewardItem()
    {
    }

    [Token(Token = "0x2002762")]
    public enum REWARD_TYPE
    {
      [Token(Token = "0x400BA38")] Arrival,
      [Token(Token = "0x400BA39")] Season,
    }
  }
}
