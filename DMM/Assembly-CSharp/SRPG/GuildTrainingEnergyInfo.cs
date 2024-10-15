// Decompiled with JetBrains decompiler
// Type: SRPG.GuildTrainingEnergyInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200253A")]
  [FlowNode.Pin(901, "予期せぬエラー検知", FlowNode.PinTypes.Output, 901)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class GuildTrainingEnergyInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AA9F")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AAA0")]
    private const int PIN_OUTPUT_ERROR = 901;
    [Token(Token = "0x400AAA1")]
    private const string SVB_NAME_MEM_COUNT_MIN = "min_member";
    [Token(Token = "0x400AAA2")]
    private const string SVB_NAME_MEM_COUNT_MAX = "max_member";
    [Token(Token = "0x400AAA3")]
    private const string SVB_NAME_ENERGY_NUM = "energy_num";
    [Token(Token = "0x400AAA4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mParent;
    [Token(Token = "0x400AAA5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mContent;
    [Token(Token = "0x400AAA6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mEmptyListObject;

    [Token(Token = "0x600A41E")]
    [Address(RVA = "0x660ED0", Offset = "0x65FCD0", VA = "0x10660ED0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A41F")]
    [Address(RVA = "0x660EF0", Offset = "0x65FCF0", VA = "0x10660EF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A420")]
    [Address(RVA = "0x660F50", Offset = "0x65FD50", VA = "0x10660F50")]
    private void SetUp()
    {
    }

    [Token(Token = "0x600A421")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildTrainingEnergyInfo()
    {
    }
  }
}
