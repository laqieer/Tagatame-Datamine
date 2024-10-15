// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailExtraRarity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C9")]
  [FlowNode.Pin(110, "NotConditions", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(100, "AnimEmd", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(11, "Click", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "AnimStart", FlowNode.PinTypes.Input, 10)]
  public class ConceptCardDetailExtraRarity : ConceptCardDetailBase, IFlowInterfaceExtend
  {
    [Token(Token = "0x4009428")]
    private const int PIN_IN_ANIM_START = 10;
    [Token(Token = "0x4009429")]
    private const int PIN_IN_CLICK_LOCK = 11;
    [Token(Token = "0x400942A")]
    private const int PIN_OUT_ANIM_END = 100;
    [Token(Token = "0x400942B")]
    private const int PIN_OUT_CLICK_LOCK = 110;
    [Token(Token = "0x400942C")]
    [FieldOffset(Offset = "0x10")]
    private readonly string ANIM_NAME_LV_TEXT_STYLE_DEFAULT;
    [Token(Token = "0x400942D")]
    [FieldOffset(Offset = "0x14")]
    private readonly string ANIM_NAME_LV_TEXT_STYLE_ENHANCE;
    [Token(Token = "0x400942E")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text CurrentExtraPointText;
    [Token(Token = "0x400942F")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text CurrentExtraPointCapText;
    [Token(Token = "0x4009430")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject CurrentSlashObject;
    [Token(Token = "0x4009431")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Slider CurrentSlider;
    [Token(Token = "0x4009432")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text PredictExtraPointText;
    [Token(Token = "0x4009433")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text PredictExtraPointCapText;
    [Token(Token = "0x4009434")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Slider PredictSlider;
    [Token(Token = "0x4009435")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject PredictArrowObject;
    [Token(Token = "0x4009436")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject PredictSlashObject;
    [Token(Token = "0x4009437")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button ExtraRarityButton;
    [Token(Token = "0x4009438")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject ExtraRarityButtonEffect;
    [Token(Token = "0x4009439")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject LockObject;
    [Token(Token = "0x400943A")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Animator CardExtraRarityAnimator;
    [Token(Token = "0x400943B")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private int SliderAnimationCoef;
    [Token(Token = "0x400943C")]
    [FieldOffset(Offset = "0x50")]
    private int _addPoint;
    [Token(Token = "0x400943D")]
    [FieldOffset(Offset = "0x54")]
    private int _needPoint;
    [Token(Token = "0x400943E")]
    [FieldOffset(Offset = "0x58")]
    private bool _isExtraRarity;

    [Token(Token = "0x17001425")]
    public bool IsExtraRarity
    {
      [Token(Token = "0x6008E98"), Address(RVA = "0x287F60", Offset = "0x286D60", VA = "0x10287F60")] get
      {
        return new bool();
      }
      [Token(Token = "0x6008E99"), Address(RVA = "0x288180", Offset = "0x286F80", VA = "0x10288180")] set
      {
      }
    }

    [Token(Token = "0x6008E9A")]
    [Address(RVA = "0x519010", Offset = "0x517E10", VA = "0x10519010", Slot = "7")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008E9B")]
    [Address(RVA = "0x518C60", Offset = "0x517A60", VA = "0x10518C60", Slot = "8")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008E9C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x6008E9D")]
    [Address(RVA = "0x5199D0", Offset = "0x5187D0", VA = "0x105199D0")]
    private void ShowLock()
    {
    }

    [Token(Token = "0x6008E9E")]
    [Address(RVA = "0x5196A0", Offset = "0x5184A0", VA = "0x105196A0")]
    private void SetExtraRarityButtonStatus(out bool is_max_point)
    {
    }

    [Token(Token = "0x6008E9F")]
    [Address(RVA = "0x519AC0", Offset = "0x5188C0", VA = "0x10519AC0")]
    private void StartAnimation()
    {
    }

    [Token(Token = "0x6008EA0")]
    [Address(RVA = "0x518E70", Offset = "0x517C70", VA = "0x10518E70")]
    private IEnumerator PlayAnimation(int start_point, int end_point) => (IEnumerator) null;

    [Token(Token = "0x6008EA1")]
    [Address(RVA = "0x518EE0", Offset = "0x517CE0", VA = "0x10518EE0")]
    private void RefreshAnimation(int point, int end_point)
    {
    }

    [Token(Token = "0x6008EA2")]
    [Address(RVA = "0x518E50", Offset = "0x517C50", VA = "0x10518E50")]
    private void EndAnimation()
    {
    }

    [Token(Token = "0x6008EA3")]
    [Address(RVA = "0x519C30", Offset = "0x518A30", VA = "0x10519C30")]
    public ConceptCardDetailExtraRarity()
    {
    }
  }
}
