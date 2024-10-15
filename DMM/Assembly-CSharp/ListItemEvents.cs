// Decompiled with JetBrains decompiler
// Type: ListItemEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010C")]
[AddComponentMenu("Event/List Item Events")]
public class ListItemEvents : MonoBehaviour
{
  [Token(Token = "0x40004E9")]
  [FieldOffset(Offset = "0xC")]
  public ListItemEvents.ListItemEvent OnSelect;
  [Token(Token = "0x40004EA")]
  [FieldOffset(Offset = "0x10")]
  public ListItemEvents.ListItemEvent OnOpenDetail;
  [Token(Token = "0x40004EB")]
  [FieldOffset(Offset = "0x14")]
  public ListItemEvents.ListItemEvent OnCloseDetail;
  [Token(Token = "0x40004EC")]
  [FieldOffset(Offset = "0x18")]
  public Transform Body;
  [Token(Token = "0x40004ED")]
  [FieldOffset(Offset = "0x1C")]
  public Vector2 DisplayRectMergin;
  [Token(Token = "0x40004EE")]
  [FieldOffset(Offset = "0x24")]
  public Vector2 ParentScale;
  [Token(Token = "0x40004EF")]
  [FieldOffset(Offset = "0x2C")]
  private RectTransform mTransform;
  [Token(Token = "0x40004F0")]
  [FieldOffset(Offset = "0x30")]
  public bool IsEnableSkillChange;
  [Token(Token = "0x40004F1")]
  [FieldOffset(Offset = "0x31")]
  public bool IsDeriveBaseAbilityDisable;
  [Token(Token = "0x40004F2")]
  [FieldOffset(Offset = "0x34")]
  private ChapterParam mChapterCache;

  [Token(Token = "0x17000111")]
  public ChapterParam Chapter
  {
    [Token(Token = "0x60006D2"), Address(RVA = "0xD5B8A0", Offset = "0xD5A6A0", VA = "0x10D5B8A0")] get
    {
      return (ChapterParam) null;
    }
  }

  [Token(Token = "0x60006D3")]
  [Address(RVA = "0xD5B5C0", Offset = "0xD5A3C0", VA = "0x10D5B5C0", Slot = "4")]
  protected virtual void Awake()
  {
  }

  [Token(Token = "0x60006D4")]
  [Address(RVA = "0xB8A920", Offset = "0xB89720", VA = "0x10B8A920")]
  public void Select()
  {
  }

  [Token(Token = "0x60006D5")]
  [Address(RVA = "0xD5B7E0", Offset = "0xD5A5E0", VA = "0x10D5B7E0")]
  public void OpenDetail()
  {
  }

  [Token(Token = "0x60006D6")]
  [Address(RVA = "0xD5B640", Offset = "0xD5A440", VA = "0x10D5B640")]
  public void CloseDetail()
  {
  }

  [Token(Token = "0x60006D7")]
  [Address(RVA = "0xD5B400", Offset = "0xD5A200", VA = "0x10D5B400")]
  public void AttachBody()
  {
  }

  [Token(Token = "0x60006D8")]
  [Address(RVA = "0xD5B670", Offset = "0xD5A470", VA = "0x10D5B670")]
  public void DetachBody(Transform pool)
  {
  }

  [Token(Token = "0x60006D9")]
  [Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")]
  public RectTransform GetRectTransform() => (RectTransform) null;

  [Token(Token = "0x60006DA")]
  [Address(RVA = "0xD5B750", Offset = "0xD5A550", VA = "0x10D5B750")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60006DB")]
  [Address(RVA = "0xD5B810", Offset = "0xD5A610", VA = "0x10D5B810")]
  public ListItemEvents()
  {
  }

  [Token(Token = "0x200010D")]
  public delegate void ListItemEvent(GameObject go);
}
