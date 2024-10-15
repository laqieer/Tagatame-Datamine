// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ExpireItemNotify
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013E2")]
  [FlowNode.NodeType("SRPG/ExpirItemNotify", 32741)]
  [FlowNode.Pin(101, "Open", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1000, "Close", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  public class FlowNode_ExpireItemNotify : FlowNode
  {
    [Token(Token = "0x40049BA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int ExpireItemWarningDay;
    [Token(Token = "0x40049BB")]
    private const int PIN_INPUT_OPEN = 101;
    [Token(Token = "0x40049BC")]
    private const int PIN_OUTPUT_CLOSE = 1000;
    [Token(Token = "0x40049BD")]
    [FieldOffset(Offset = "0x1C")]
    [StringIsResourcePath(typeof (GameObject))]
    public string mNotifyPrefabPath;
    [Token(Token = "0x40049BE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private FlowNode_ExpireItemNotify.eNotifyType mNotifyType;
    [Token(Token = "0x40049BF")]
    [FieldOffset(Offset = "0x0")]
    private static bool IsWarningNotified;
    [Token(Token = "0x40049C0")]
    [FieldOffset(Offset = "0x24")]
    private int mTargetWarningDay;

    [Token(Token = "0x6005345")]
    [Address(RVA = "0x127E9B0", Offset = "0x127D7B0", VA = "0x1127E9B0")]
    public static void Deserialize(Json_ExpireItem[] json_items)
    {
    }

    [Token(Token = "0x6005346")]
    [Address(RVA = "0x127F7B0", Offset = "0x127E5B0", VA = "0x1127F7B0")]
    public static void ResetParam()
    {
    }

    [Token(Token = "0x6005347")]
    [Address(RVA = "0x127E910", Offset = "0x127D710", VA = "0x1127E910")]
    private static void ClearPrefs()
    {
    }

    [Token(Token = "0x6005348")]
    [Address(RVA = "0x127EBC0", Offset = "0x127D9C0", VA = "0x1127EBC0")]
    private static ExpireItemParamList GetExpireItem() => (ExpireItemParamList) null;

    [Token(Token = "0x6005349")]
    [Address(RVA = "0x127F170", Offset = "0x127DF70", VA = "0x1127F170", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600534A")]
    [Address(RVA = "0x127F730", Offset = "0x127E530", VA = "0x1127F730")]
    private void Open()
    {
    }

    [Token(Token = "0x600534B")]
    [Address(RVA = "0x127F4A0", Offset = "0x127E2A0", VA = "0x1127F4A0")]
    private void Open_ExpireWarning()
    {
    }

    [Token(Token = "0x600534C")]
    [Address(RVA = "0x127F1F0", Offset = "0x127DFF0", VA = "0x1127F1F0")]
    private void Open_ExpireWarning(int target_day)
    {
    }

    [Token(Token = "0x600534D")]
    [Address(RVA = "0x127F140", Offset = "0x127DF40", VA = "0x1127F140")]
    private void NextWarning()
    {
    }

    [Token(Token = "0x600534E")]
    [Address(RVA = "0x127F500", Offset = "0x127E300", VA = "0x1127F500")]
    private void Open_ExpiredNotify()
    {
    }

    [Token(Token = "0x600534F")]
    [Address(RVA = "0x127ED40", Offset = "0x127DB40", VA = "0x1127ED40")]
    private List<ItemData>[] GetExpireWarningItems(int target_day) => (List<ItemData>[]) null;

    [Token(Token = "0x6005350")]
    private bool MyContains<T>(List<T>[] array, T target) => new bool();

    [Token(Token = "0x6005351")]
    [Address(RVA = "0x127F7E0", Offset = "0x127E5E0", VA = "0x1127F7E0")]
    public FlowNode_ExpireItemNotify()
    {
    }

    [Token(Token = "0x20013E3")]
    public enum eNotifyType
    {
      [Token(Token = "0x40049C2")] None,
      [Token(Token = "0x40049C3")] Warning,
      [Token(Token = "0x40049C4")] Expired,
    }
  }
}
