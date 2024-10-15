// Decompiled with JetBrains decompiler
// Type: SRPG.Exhibit.IDynamicRenderModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Exhibit
{
  [Token(Token = "0x2003436")]
  public interface IDynamicRenderModel : IRenderModel
  {
    [Token(Token = "0x600E944")]
    void Render<T>(T model) where T : class;
  }
}
