// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerRewardItemUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20027AF")]
  [AddComponentMenu("UI/MultiTowerRewardItemUI")]
  public class MultiTowerRewardItemUI : MonoBehaviour
  {
    [Token(Token = "0x400BBC1")]
    [FieldOffset(Offset = "0xC")]
    public GameObject unitObj;
    [Token(Token = "0x400BBC2")]
    [FieldOffset(Offset = "0x10")]
    public GameObject itemObj;
    [Token(Token = "0x400BBC3")]
    [FieldOffset(Offset = "0x14")]
    public GameObject amountObj;
    [Token(Token = "0x400BBC4")]
    [FieldOffset(Offset = "0x18")]
    public GameParameter iconParam;
    [Token(Token = "0x400BBC5")]
    [FieldOffset(Offset = "0x1C")]
    public GameParameter frameParam;
    [Token(Token = "0x400BBC6")]
    [FieldOffset(Offset = "0x20")]
    public RawImage itemTex;
    [Token(Token = "0x400BBC7")]
    [FieldOffset(Offset = "0x24")]
    public Image frameTex;
    [Token(Token = "0x400BBC8")]
    [FieldOffset(Offset = "0x28")]
    public Texture coinTex;
    [Token(Token = "0x400BBC9")]
    [FieldOffset(Offset = "0x2C")]
    public Texture goldTex;
    [Token(Token = "0x400BBCA")]
    [FieldOffset(Offset = "0x30")]
    public Sprite coinBase;
    [Token(Token = "0x400BBCB")]
    [FieldOffset(Offset = "0x34")]
    public Sprite goldBase;
    [Token(Token = "0x400BBCC")]
    [FieldOffset(Offset = "0x38")]
    public Text rewardName;
    [Token(Token = "0x400BBCD")]
    [FieldOffset(Offset = "0x3C")]
    public Text rewardFloor;
    [Token(Token = "0x400BBCE")]
    [FieldOffset(Offset = "0x40")]
    public RectTransform pos;
    [Token(Token = "0x400BBCF")]
    [FieldOffset(Offset = "0x44")]
    public Text rewardDetailName;
    [Token(Token = "0x400BBD0")]
    [FieldOffset(Offset = "0x48")]
    public Text rewardDetailInfo;
    [Token(Token = "0x400BBD1")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject currentMark;
    [Token(Token = "0x400BBD2")]
    [FieldOffset(Offset = "0x50")]
    public GameObject clearMark;
    [Token(Token = "0x400BBD3")]
    [FieldOffset(Offset = "0x54")]
    public GameObject current_fil;
    [Token(Token = "0x400BBD4")]
    [FieldOffset(Offset = "0x58")]
    public GameObject cleared_fil;
    [Token(Token = "0x400BBD5")]
    [FieldOffset(Offset = "0x5C")]
    private int mIdx;

    [Token(Token = "0x600B235")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B236")]
    [Address(RVA = "0x766950", Offset = "0x765750", VA = "0x10766950")]
    public void Refresh(int idx = 0)
    {
    }

    [Token(Token = "0x600B237")]
    [Address(RVA = "0x766A90", Offset = "0x765890", VA = "0x10766A90")]
    public void SetData(int idx = 0)
    {
    }

    [Token(Token = "0x600B238")]
    [Address(RVA = "0x766490", Offset = "0x765290", VA = "0x10766490")]
    public void OnDetailClick()
    {
    }

    [Token(Token = "0x600B239")]
    [Address(RVA = "0x767BA0", Offset = "0x7669A0", VA = "0x10767BA0")]
    public MultiTowerRewardItemUI()
    {
    }
  }
}
