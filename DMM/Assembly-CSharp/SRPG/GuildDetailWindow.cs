// Decompiled with JetBrains decompiler
// Type: SRPG.GuildDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002560")]
  [FlowNode.Pin(1010, "ギルド情報取得リクエスト", FlowNode.PinTypes.Output, 1010)]
  [AddComponentMenu("UI/GuildDetailWindow")]
  [FlowNode.Pin(10, "表示更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1020, "ギルド加入リクエスト", FlowNode.PinTypes.Output, 1020)]
  public class GuildDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AC72")]
    private const int PIN_INPUT_REFRESH = 10;
    [Token(Token = "0x400AC73")]
    private const int PIN_OUTPUT_REQUEST_GUILD_INFO = 1010;
    [Token(Token = "0x400AC74")]
    private const int PIN_OUTPUT_ENTRY_REQUEST = 1020;
    [Token(Token = "0x400AC75")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Button mAppButton;
    [Token(Token = "0x400AC76")]
    [FieldOffset(Offset = "0x10")]
    private bool IsDrawAppButton;
    [Token(Token = "0x400AC77")]
    [FieldOffset(Offset = "0x14")]
    private GuildData mGuild;

    [Token(Token = "0x600A55F")]
    [Address(RVA = "0x676DB0", Offset = "0x675BB0", VA = "0x10676DB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A560")]
    [Address(RVA = "0x676DD0", Offset = "0x675BD0", VA = "0x10676DD0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A561")]
    [Address(RVA = "0x6771C0", Offset = "0x675FC0", VA = "0x106771C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A562")]
    [Address(RVA = "0x676FE0", Offset = "0x675DE0", VA = "0x10676FE0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A563")]
    [Address(RVA = "0x676E30", Offset = "0x675C30", VA = "0x10676E30")]
    public void OnRequestEntry()
    {
    }

    [Token(Token = "0x600A564")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildDetailWindow()
    {
    }
  }
}
