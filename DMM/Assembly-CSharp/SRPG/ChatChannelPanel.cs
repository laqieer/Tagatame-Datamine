// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannelPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002154")]
  [FlowNode.Pin(0, "Channel Select", FlowNode.PinTypes.Output, 0)]
  [AddComponentMenu("UI/ChatChannelPanel")]
  public class ChatChannelPanel : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400913A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform lists;
    [Token(Token = "0x400913B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text Title;
    [Token(Token = "0x400913C")]
    [FieldOffset(Offset = "0x14")]
    private Transform[] items;
    [Token(Token = "0x400913D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_ToggleButton[] ChannelButtons;
    [Token(Token = "0x400913E")]
    [FieldOffset(Offset = "0x1C")]
    private int mActiveChanneID;

    [Token(Token = "0x6008BF5")]
    [Address(RVA = "0x4FAE60", Offset = "0x4F9C60", VA = "0x104FAE60")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008BF6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int piniD)
    {
    }

    [Token(Token = "0x6008BF7")]
    [Address(RVA = "0x4FB230", Offset = "0x4FA030", VA = "0x104FB230")]
    public void Refresh(ChatChannelParam[] ch_params)
    {
    }

    [Token(Token = "0x6008BF8")]
    [Address(RVA = "0x4FB110", Offset = "0x4F9F10", VA = "0x104FB110")]
    public void OnChannelChange(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008BF9")]
    [Address(RVA = "0x4FB060", Offset = "0x4F9E60", VA = "0x104FB060")]
    private bool ChannelChange(SRPG_Button button) => new bool();

    [Token(Token = "0x6008BFA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChatChannelPanel()
    {
    }
  }
}
