import "@typespec/http";
import "@typespec/rest";

@service({
    title: "PutBytes",
  })
   
  namespace PutBytes;
   
  using TypeSpec.Http;
  using TypeSpec.Rest;
     
  interface PutBytesClient {
    @put @route("upload") Upload(document: bytes) : void;
  }