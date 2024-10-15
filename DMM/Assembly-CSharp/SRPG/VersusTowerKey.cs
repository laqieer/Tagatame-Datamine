// Decompiled with JetBrains decompiler
// Type: SRPG.VersusTowerKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002758")]
  [FlowNode.Pin(2, "階層更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "鍵の更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "演出終了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Multi/Versus/VersusTowerKey")]
  [FlowNode.Pin(3, "到達報酬", FlowNode.PinTypes.Input, 0)]
  public class VersusTowerKey : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B9C2")]
    [FieldOffset(Offset = "0xC")]
    public Text floortxt;
    [Token(Token = "0x400B9C3")]
    [FieldOffset(Offset = "0x10")]
    public Text floorEfftxt;
    [Token(Token = "0x400B9C4")]
    [FieldOffset(Offset = "0x14")]
    public Text okText;
    [Token(Token = "0x400B9C5")]
    [FieldOffset(Offset = "0x18")]
    public Text arrivalNumText;
    [Token(Token = "0x400B9C6")]
    [FieldOffset(Offset = "0x1C")]
    public Text arrivalEffNumText;
    [Token(Token = "0x400B9C7")]
    [FieldOffset(Offset = "0x20")]
    public Text arrivalRewardText;
    [Token(Token = "0x400B9C8")]
    [FieldOffset(Offset = "0x24")]
    public GameObject key;
    [Token(Token = "0x400B9C9")]
    [FieldOffset(Offset = "0x28")]
    public GameObject parent;
    [Token(Token = "0x400B9CA")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject floorObj;
    [Token(Token = "0x400B9CB")]
    [FieldOffset(Offset = "0x30")]
    public GameObject rewardObj;
    [Token(Token = "0x400B9CC")]
    [FieldOffset(Offset = "0x34")]
    public GameObject unitObj;
    [Token(Token = "0x400B9CD")]
    [FieldOffset(Offset = "0x38")]
    public GameObject itemRoot;
    [Token(Token = "0x400B9CE")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject arrivalObj;
    [Token(Token = "0x400B9CF")]
    [FieldOffset(Offset = "0x40")]
    public GameObject keyRoot;
    [Token(Token = "0x400B9D0")]
    [FieldOffset(Offset = "0x44")]
    public GameObject rewardRoot;
    [Token(Token = "0x400B9D1")]
    [FieldOffset(Offset = "0x48")]
    public GameObject reglegationRoot;
    [Token(Token = "0x400B9D2")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject ArrivalInfoRoot;
    [Token(Token = "0x400B9D3")]
    [FieldOffset(Offset = "0x50")]
    public GameObject ClearInfoRoot;
    [Token(Token = "0x400B9D4")]
    [FieldOffset(Offset = "0x54")]
    public GameObject RightRoot;
    [Token(Token = "0x400B9D5")]
    [FieldOffset(Offset = "0x58")]
    public GameObject infoText;
    [Token(Token = "0x400B9D6")]
    [FieldOffset(Offset = "0x5C")]
    public Text infoLastText;
    [Token(Token = "0x400B9D7")]
    [FieldOffset(Offset = "0x60")]
    public Image frameObj;
    [Token(Token = "0x400B9D8")]
    [FieldOffset(Offset = "0x64")]
    public Sprite coinBase;
    [Token(Token = "0x400B9D9")]
    [FieldOffset(Offset = "0x68")]
    public Sprite goldBase;
    [Token(Token = "0x400B9DA")]
    [FieldOffset(Offset = "0x6C")]
    public RawImage rewardTex;
    [Token(Token = "0x400B9DB")]
    [FieldOffset(Offset = "0x70")]
    public string keyGetAnim;
    [Token(Token = "0x400B9DC")]
    [FieldOffset(Offset = "0x74")]
    public string keyDefAnim;
    [Token(Token = "0x400B9DD")]
    [FieldOffset(Offset = "0x78")]
    public string keyLostAnim;
    [Token(Token = "0x400B9DE")]
    [FieldOffset(Offset = "0x7C")]
    public string updateFloorAnim;
    [Token(Token = "0x400B9DF")]
    [FieldOffset(Offset = "0x80")]
    public string downFloorAnim;
    [Token(Token = "0x400B9E0")]
    [FieldOffset(Offset = "0x84")]
    public string rewardGetAnim;
    [Token(Token = "0x400B9E1")]
    [FieldOffset(Offset = "0x88")]
    public string trriggerIn;
    [Token(Token = "0x400B9E2")]
    [FieldOffset(Offset = "0x8C")]
    public string trriggerOut;
    [Token(Token = "0x400B9E3")]
    [FieldOffset(Offset = "0x90")]
    public string trriggerRewardIn;
    [Token(Token = "0x400B9E4")]
    [FieldOffset(Offset = "0x94")]
    public string trriggerInLastFloor;
    [Token(Token = "0x400B9E5")]
    [FieldOffset(Offset = "0x98")]
    public string trriggerInLastFloorOut;
    [Token(Token = "0x400B9E6")]
    [FieldOffset(Offset = "0x9C")]
    public Color rankDownColor;
    [Token(Token = "0x400B9E7")]
    [FieldOffset(Offset = "0xAC")]
    public Texture CoinTex;
    [Token(Token = "0x400B9E8")]
    [FieldOffset(Offset = "0xB0")]
    public Texture GoldTex;
    [Token(Token = "0x400B9E9")]
    [FieldOffset(Offset = "0xB4")]
    private VersusTowerKey.KEY_RESULT_STATE mState;
    [Token(Token = "0x400B9EA")]
    [FieldOffset(Offset = "0xB8")]
    private VersusTowerKey.RESULT mBattleRes;
    [Token(Token = "0x400B9EB")]
    [FieldOffset(Offset = "0xBC")]
    private bool mUpdateAnim;
    [Token(Token = "0x400B9EC")]
    [FieldOffset(Offset = "0xBD")]
    private bool mUpdateFloor;
    [Token(Token = "0x400B9ED")]
    [FieldOffset(Offset = "0xC0")]
    private int mAnimKeyIndex;
    [Token(Token = "0x400B9EE")]
    [FieldOffset(Offset = "0xC4")]
    private int mMaxKeyCount;
    [Token(Token = "0x400B9EF")]
    [FieldOffset(Offset = "0xC8")]
    private List<GameObject> mCreateKey;

    [Token(Token = "0x600B08A")]
    [Address(RVA = "0x7536B0", Offset = "0x7524B0", VA = "0x107536B0")]
    private void Start()
    {
    }

    [Token(Token = "0x600B08B")]
    [Address(RVA = "0x752B50", Offset = "0x751950", VA = "0x10752B50")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600B08C")]
    [Address(RVA = "0x753380", Offset = "0x752180", VA = "0x10753380")]
    private void SetButtonText(bool bNext)
    {
    }

    [Token(Token = "0x600B08D")]
    [Address(RVA = "0x753450", Offset = "0x752250", VA = "0x10753450")]
    private void SetupRewardItem()
    {
    }

    [Token(Token = "0x600B08E")]
    [Address(RVA = "0x752870", Offset = "0x751670", VA = "0x10752870", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B08F")]
    [Address(RVA = "0x753730", Offset = "0x752530", VA = "0x10753730", Slot = "5")]
    public virtual IEnumerator UpdateKeyAnim() => (IEnumerator) null;

    [Token(Token = "0x600B090")]
    [Address(RVA = "0x7537A0", Offset = "0x7525A0", VA = "0x107537A0", Slot = "6")]
    public virtual IEnumerator UpdateLostKeyAnim() => (IEnumerator) null;

    [Token(Token = "0x600B091")]
    [Address(RVA = "0x7536C0", Offset = "0x7524C0", VA = "0x107536C0", Slot = "7")]
    public virtual IEnumerator UpdateFloorAnim() => (IEnumerator) null;

    [Token(Token = "0x600B092")]
    [Address(RVA = "0x753810", Offset = "0x752610", VA = "0x10753810", Slot = "8")]
    public virtual IEnumerator UpdateRewardAnim() => (IEnumerator) null;

    [Token(Token = "0x600B093")]
    [Address(RVA = "0x753290", Offset = "0x752090", VA = "0x10753290")]
    private void ReqAnim(string trrigger, bool isAnimator = false)
    {
    }

    [Token(Token = "0x600B094")]
    [Address(RVA = "0x752960", Offset = "0x751760", VA = "0x10752960")]
    public void OnClickNextButton()
    {
    }

    [Token(Token = "0x600B095")]
    [Address(RVA = "0x753880", Offset = "0x752680", VA = "0x10753880")]
    public VersusTowerKey()
    {
    }

    [Token(Token = "0x2002759")]
    private enum KEY_RESULT_STATE
    {
      [Token(Token = "0x400B9F1")] NONE,
      [Token(Token = "0x400B9F2")] GET_KEY,
      [Token(Token = "0x400B9F3")] UPDATE_FLOOR,
      [Token(Token = "0x400B9F4")] GET_REWARD,
    }

    [Token(Token = "0x200275A")]
    private enum RESULT
    {
      [Token(Token = "0x400B9F6")] WIN,
      [Token(Token = "0x400B9F7")] LOSE,
      [Token(Token = "0x400B9F8")] DRAW,
    }
  }
}
