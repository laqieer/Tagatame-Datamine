// Decompiled with JetBrains decompiler
// Type: SRPG.InGameMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FC1")]
  [AddComponentMenu("Common/InGameMenu")]
  [FlowNode.Pin(2, "Give Up", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Close Give Up Window", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Start Debug", FlowNode.PinTypes.Input, 0)]
  public class InGameMenu : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4003799")]
    public const int PINID_DEBUG = 1;
    [Token(Token = "0x400379A")]
    public const int PINID_GIVEUP = 2;
    [Token(Token = "0x400379B")]
    public const int PINID_CLOSE_GIVEUP_WINDOW = 100;
    [Token(Token = "0x400379C")]
    [FieldOffset(Offset = "0xC")]
    public GameObject MissionButton;
    [Token(Token = "0x400379D")]
    [FieldOffset(Offset = "0x10")]
    public GameObject ExitButton;
    [Token(Token = "0x400379E")]
    [FieldOffset(Offset = "0x14")]
    public GameObject OptionButton;
    [Token(Token = "0x400379F")]
    [FieldOffset(Offset = "0x18")]
    public GameObject DebugButton;
    [Token(Token = "0x40037A0")]
    [FieldOffset(Offset = "0x1C")]
    public Button AutoPlayOn;
    [Token(Token = "0x40037A1")]
    [FieldOffset(Offset = "0x20")]
    public Button AutoPlayOff;
    [Token(Token = "0x40037A2")]
    [FieldOffset(Offset = "0x24")]
    public Toggle AutoPlay;
    [Token(Token = "0x40037A3")]
    [FieldOffset(Offset = "0x28")]
    public GameObject AutoMode_Parent;
    [Token(Token = "0x40037A4")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject AutoMode_Treasure;
    [Token(Token = "0x40037A5")]
    [FieldOffset(Offset = "0x30")]
    public GameObject AutoMode_Skill;
    [Token(Token = "0x40037A6")]
    [FieldOffset(Offset = "0x34")]
    public GameObject MultiHiSpeedParent;
    [Token(Token = "0x40037A7")]
    [FieldOffset(Offset = "0x38")]
    private GameObject mGiveUpWindow;
    [Token(Token = "0x40037A8")]
    [FieldOffset(Offset = "0x3C")]
    public bool HideMissionButton;
    [Token(Token = "0x40037A9")]
    [FieldOffset(Offset = "0x0")]
    private static InGameMenu mInstance;

    [Token(Token = "0x170005D9")]
    public static InGameMenu Instance
    {
      [Token(Token = "0x6004188"), Address(RVA = "0x1195710", Offset = "0x1194510", VA = "0x11195710")] get
      {
        return (InGameMenu) null;
      }
    }

    [Token(Token = "0x6004189")]
    [Address(RVA = "0x1193C90", Offset = "0x1192A90", VA = "0x11193C90")]
    private void Awake()
    {
    }

    [Token(Token = "0x600418A")]
    [Address(RVA = "0x1194230", Offset = "0x1193030", VA = "0x11194230")]
    private void Start()
    {
    }

    [Token(Token = "0x600418B")]
    [Address(RVA = "0x1195470", Offset = "0x1194270", VA = "0x11195470")]
    private void ToggleAutoPlay(bool enable)
    {
    }

    [Token(Token = "0x600418C")]
    [Address(RVA = "0x11956E0", Offset = "0x11944E0", VA = "0x111956E0")]
    private void TurnOnAutoPlay()
    {
    }

    [Token(Token = "0x600418D")]
    [Address(RVA = "0x11956C0", Offset = "0x11944C0", VA = "0x111956C0")]
    private void TurnOffAutoPlay()
    {
    }

    [Token(Token = "0x600418E")]
    [Address(RVA = "0x1194E30", Offset = "0x1193C30", VA = "0x11194E30")]
    public void ToggleAutoBattle(bool is_active)
    {
    }

    [Token(Token = "0x600418F")]
    [Address(RVA = "0x1193DB0", Offset = "0x1192BB0", VA = "0x11193DB0")]
    public void MultiAutoDisplay(bool isActive)
    {
    }

    [Token(Token = "0x6004190")]
    [Address(RVA = "0x1193EF0", Offset = "0x1192CF0", VA = "0x11193EF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004191")]
    [Address(RVA = "0x1194210", Offset = "0x1193010", VA = "0x11194210")]
    private void OnQuestEnd()
    {
    }

    [Token(Token = "0x6004192")]
    [Address(RVA = "0x1193960", Offset = "0x1192760", VA = "0x11193960", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6004193")]
    [Address(RVA = "0x1194050", Offset = "0x1192E50", VA = "0x11194050")]
    private void OnGiveUp(GameObject go)
    {
    }

    [Token(Token = "0x6004194")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public InGameMenu()
    {
    }
  }
}
