// Decompiled with JetBrains decompiler
// Type: SRPG.ChatEditTemplateMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002157")]
  [AddComponentMenu("UI/ChatEditTemplateMessage")]
  [FlowNode.Pin(101, "NGワードが存在", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "定型文の変更", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  public class ChatEditTemplateMessage : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400914C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_Button[] submit_buttons;
    [Token(Token = "0x400914D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private InputFieldCensorship[] input_fields;
    [Token(Token = "0x400914E")]
    [FieldOffset(Offset = "0x14")]
    private ChatUtility.Json_ChatTemplateData prefs_data;
    [Token(Token = "0x400914F")]
    [FieldOffset(Offset = "0x18")]
    private List<ChatUtility.ChatInspectionMaster> chat_inspecton_master;
    [Token(Token = "0x4009150")]
    [FieldOffset(Offset = "0x1C")]
    private bool is_loaded_inspection_master;

    [Token(Token = "0x6008C06")]
    [Address(RVA = "0x4FC190", Offset = "0x4FAF90", VA = "0x104FC190", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008C07")]
    [Address(RVA = "0x4FC590", Offset = "0x4FB390", VA = "0x104FC590")]
    private void Init()
    {
    }

    [Token(Token = "0x6008C08")]
    [Address(RVA = "0x4FC1B0", Offset = "0x4FAFB0", VA = "0x104FC1B0")]
    private void InitButtons()
    {
    }

    [Token(Token = "0x6008C09")]
    [Address(RVA = "0x4FC300", Offset = "0x4FB100", VA = "0x104FC300")]
    private void InitInputFields()
    {
    }

    [Token(Token = "0x6008C0A")]
    [Address(RVA = "0x4FCA90", Offset = "0x4FB890", VA = "0x104FCA90")]
    public void TextValueChanged(GameObject obj)
    {
    }

    [Token(Token = "0x6008C0B")]
    [Address(RVA = "0x4FC760", Offset = "0x4FB560", VA = "0x104FC760")]
    private void OnClickSubmitButton(SRPG_Button button)
    {
    }

    [Token(Token = "0x6008C0C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ChatEditTemplateMessage()
    {
    }
  }
}
