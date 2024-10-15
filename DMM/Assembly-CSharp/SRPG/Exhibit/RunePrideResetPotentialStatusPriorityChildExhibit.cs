// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.RunePrideResetPotentialStatusPriorityChildExhibit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Models;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x20034E1")]
  public class RunePrideResetPotentialStatusPriorityChildExhibit : 
    BaseItemExhibit,
    IRenderModel<RunePrideResetPotentialStatusPriorityChildModel>,
    IRenderModel
  {
    [Token(Token = "0x400FB09")]
    [FieldOffset(Offset = "0x38")]
    [CustomGroup("基本")]
    [CustomField("タイプ", CustomFieldAttribute.Type.EnumString, typeof (RunePrideResetPotentialStatusPriorityChildExhibit.EKey), typeof (RunePrideResetPotentialStatusPriorityChildExhibit))]
    public string m_KeyName;

    [Token(Token = "0x600EA48")]
    [Address(RVA = "0xAF4CB0", Offset = "0xAF3AB0", VA = "0x10AF4CB0", Slot = "9")]
    public void Render(
      RunePrideResetPotentialStatusPriorityChildModel _model)
    {
    }

    [Token(Token = "0x600EA49")]
    [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
    public RunePrideResetPotentialStatusPriorityChildExhibit()
    {
    }

    [Token(Token = "0x20034E2")]
    private enum EKey
    {
      [Token(Token = "0x400FB0B")] None,
      [Token(Token = "0x400FB0C")] InfiniteChar,
      [Token(Token = "0x400FB0D")] HaveCount,
      [Token(Token = "0x400FB0E")] UseCount,
    }
  }
}
