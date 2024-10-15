// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_OpenedQuestArchivesListResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010B9")]
  [Serializable]
  public class JSON_OpenedQuestArchivesListResponse
  {
    [Token(Token = "0x4003C07")]
    [FieldOffset(Offset = "0x8")]
    public JSON_OpenedQuestArchive[] archives;
    [Token(Token = "0x4003C08")]
    [FieldOffset(Offset = "0xC")]
    public int free_end;

    [Token(Token = "0x60046D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_OpenedQuestArchivesListResponse()
    {
    }
  }
}
