// Decompiled with JetBrains decompiler
// Type: SRPG.DropItemSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002305")]
  public class DropItemSource : ContentSource
  {
    [Token(Token = "0x60096C0")]
    [Address(RVA = "0x596ED0", Offset = "0x595CD0", VA = "0x10596ED0", Slot = "4")]
    public override void Initialize(ContentController controller)
    {
    }

    [Token(Token = "0x60096C1")]
    [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
    public override void Release()
    {
    }

    [Token(Token = "0x60096C2")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public DropItemSource()
    {
    }

    [Token(Token = "0x2002306")]
    public class DropItemParam : ContentSource.Param
    {
      [Token(Token = "0x4009C52")]
      [FieldOffset(Offset = "0x10")]
      private QuestResult.DropItemData mDropItem;

      [Token(Token = "0x60096C3")]
      [Address(RVA = "0x596DE0", Offset = "0x595BE0", VA = "0x10596DE0", Slot = "6")]
      public override bool IsValid() => new bool();

      [Token(Token = "0x60096C4")]
      [Address(RVA = "0x596EA0", Offset = "0x595CA0", VA = "0x10596EA0")]
      public DropItemParam(QuestResult.DropItemData drop_item)
      {
      }

      [Token(Token = "0x60096C5")]
      [Address(RVA = "0x596DF0", Offset = "0x595BF0", VA = "0x10596DF0", Slot = "12")]
      public override void OnEnable(ContentNode node)
      {
      }
    }
  }
}
