// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FB5")]
  [FlowNode.Pin(102, "表示更新完了", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/Adventure/AdventureTop")]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初回表示処理", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "初回表示処理完了", FlowNode.PinTypes.Output, 101)]
  public class AdventureTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008652")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008653")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x4008654")]
    private const int PIN_OUTPUT_INIT_END = 101;
    [Token(Token = "0x4008655")]
    private const int PIN_OUTPUT_REFRESH_END = 102;
    [Token(Token = "0x4008656")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private AdventureAreaIcon BaseAreaIcon;
    [Token(Token = "0x4008657")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<GameObject> AdventureAreaPoints;
    [Token(Token = "0x4008658")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text NowAdventureTeamCount;
    [Token(Token = "0x4008659")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text MaxAdventureTeamCount;
    [Token(Token = "0x400865A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text NowAdventureEndCount;
    [Token(Token = "0x400865B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text TargetAdventureEndCount;
    [Token(Token = "0x400865C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Slider AdventureEndCountGauge;
    [Token(Token = "0x400865D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private float IconAnimStartDelay;
    [Token(Token = "0x400865E")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject DispatchBundleAlert;
    [Token(Token = "0x400865F")]
    [FieldOffset(Offset = "0x30")]
    private AdventureManager mManager;
    [Token(Token = "0x4008660")]
    [FieldOffset(Offset = "0x34")]
    private List<AdventureAreaIcon> mAreaIcons;

    [Token(Token = "0x60082A0")]
    [Address(RVA = "0x433D00", Offset = "0x432B00", VA = "0x10433D00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60082A1")]
    [Address(RVA = "0x433E00", Offset = "0x432C00", VA = "0x10433E00")]
    private void Awake()
    {
    }

    [Token(Token = "0x60082A2")]
    [Address(RVA = "0x434060", Offset = "0x432E60", VA = "0x10434060")]
    private void Init()
    {
    }

    [Token(Token = "0x60082A3")]
    [Address(RVA = "0x4346F0", Offset = "0x4334F0", VA = "0x104346F0")]
    private void SetUpAreaIcon()
    {
    }

    [Token(Token = "0x60082A4")]
    [Address(RVA = "0x434120", Offset = "0x432F20", VA = "0x10434120")]
    private void RefreshAreaIcon()
    {
    }

    [Token(Token = "0x60082A5")]
    [Address(RVA = "0x4342E0", Offset = "0x4330E0", VA = "0x104342E0")]
    private void RefreshUI()
    {
    }

    [Token(Token = "0x60082A6")]
    [Address(RVA = "0x433E50", Offset = "0x432C50", VA = "0x10433E50")]
    private void CheckAdvNotification()
    {
    }

    [Token(Token = "0x60082A7")]
    [Address(RVA = "0x434B40", Offset = "0x433940", VA = "0x10434B40")]
    public AdventureTop()
    {
    }
  }
}
