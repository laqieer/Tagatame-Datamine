// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureSlot
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
  [Token(Token = "0x2001FB1")]
  [FlowNode.Pin(1, "スロット選択", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/Adventure/AdventureSlot")]
  public class AdventureSlot : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008635")]
    private const int PIN_INPUT_ONCLICK = 1;
    [Token(Token = "0x4008636")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button IconButton;
    [Token(Token = "0x4008637")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject AnimObj;
    [Token(Token = "0x4008638")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Animator UnitChangeAnim;
    [Token(Token = "0x4008639")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string UnitChangeAnimName;
    [Token(Token = "0x400863A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject UnitUIObj;
    [Token(Token = "0x400863B")]
    [FieldOffset(Offset = "0x20")]
    private AdventureMenu mAdMenu;
    [Token(Token = "0x400863C")]
    [FieldOffset(Offset = "0x24")]
    private int mSlotNum;
    [Token(Token = "0x400863D")]
    [FieldOffset(Offset = "0x28")]
    private Coroutine mDelayChangeAnim;

    [Token(Token = "0x6008287")]
    [Address(RVA = "0x432CE0", Offset = "0x431AE0", VA = "0x10432CE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008288")]
    [Address(RVA = "0x432EE0", Offset = "0x431CE0", VA = "0x10432EE0")]
    public void SetUp(AdventureMenu _menu, int _slot_num, bool _is_button_active)
    {
    }

    [Token(Token = "0x6008289")]
    [Address(RVA = "0x432E60", Offset = "0x431C60", VA = "0x10432E60")]
    public void SetAnimFlag(bool _anim_flag)
    {
    }

    [Token(Token = "0x600828A")]
    [Address(RVA = "0x432F70", Offset = "0x431D70", VA = "0x10432F70")]
    public void StartUnitChangeAnim(float _delay_time)
    {
    }

    [Token(Token = "0x600828B")]
    [Address(RVA = "0x432DF0", Offset = "0x431BF0", VA = "0x10432DF0")]
    private void OpenUnitList()
    {
    }

    [Token(Token = "0x600828C")]
    [Address(RVA = "0x432D60", Offset = "0x431B60", VA = "0x10432D60")]
    private IEnumerator DelayChangeAnim(float _delay_time) => (IEnumerator) null;

    [Token(Token = "0x600828D")]
    [Address(RVA = "0x432DD0", Offset = "0x431BD0", VA = "0x10432DD0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600828E")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureSlot()
    {
    }
  }
}
