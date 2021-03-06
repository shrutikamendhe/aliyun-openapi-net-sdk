/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SearchTemplateResponseUnmarshaller
    {
        public static SearchTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			SearchTemplateResponse searchTemplateResponse = new SearchTemplateResponse();

			searchTemplateResponse.HttpResponse = context.HttpResponse;
			searchTemplateResponse.RequestId = context.StringValue("SearchTemplate.RequestId");
			searchTemplateResponse.TotalCount = context.LongValue("SearchTemplate.TotalCount");
			searchTemplateResponse.PageNumber = context.LongValue("SearchTemplate.PageNumber");
			searchTemplateResponse.PageSize = context.LongValue("SearchTemplate.PageSize");

			List<SearchTemplateResponse.Template> templateList = new List<SearchTemplateResponse.Template>();
			for (int i = 0; i < context.Length("SearchTemplate.TemplateList.Length"); i++) {
				SearchTemplateResponse.Template template = new SearchTemplateResponse.Template();
				template.Id = context.StringValue("SearchTemplate.TemplateList["+ i +"].Id");
				template.Name = context.StringValue("SearchTemplate.TemplateList["+ i +"].Name");
				template.State = context.StringValue("SearchTemplate.TemplateList["+ i +"].State");

				SearchTemplateResponse.Template.Container_ container = new SearchTemplateResponse.Template.Container_();
				container.Format = context.StringValue("SearchTemplate.TemplateList["+ i +"].Container.Format");
				template.Container = container;

				SearchTemplateResponse.Template.Video_ video = new SearchTemplateResponse.Template.Video_();
				video.Codec = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Codec");
				video.Profile = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Profile");
				video.Bitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bitrate");
				video.Crf = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Crf");
				video.Width = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Width");
				video.Height = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Height");
				video.Fps = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Fps");
				video.Gop = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Gop");
				video.Preset = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Preset");
				video.ScanMode = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.ScanMode");
				video.Bufsize = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Bufsize");
				video.Maxrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Maxrate");
				video.PixFmt = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.PixFmt");
				video.Degrain = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Degrain");
				video.Qscale = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Qscale");
				video.Remove = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.Remove");

				SearchTemplateResponse.Template.Video_.BitrateBnd_ bitrateBnd = new SearchTemplateResponse.Template.Video_.BitrateBnd_();
				bitrateBnd.Max = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Max");
				bitrateBnd.Min = context.StringValue("SearchTemplate.TemplateList["+ i +"].Video.BitrateBnd.Min");
				video.BitrateBnd = bitrateBnd;
				template.Video = video;

				SearchTemplateResponse.Template.Audio_ audio = new SearchTemplateResponse.Template.Audio_();
				audio.Codec = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Codec");
				audio.Profile = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Profile");
				audio.Samplerate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Samplerate");
				audio.Bitrate = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Bitrate");
				audio.Channels = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Channels");
				audio.Qscale = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Qscale");
				audio.Remove = context.StringValue("SearchTemplate.TemplateList["+ i +"].Audio.Remove");
				template.Audio = audio;

				SearchTemplateResponse.Template.TransConfig_ transConfig = new SearchTemplateResponse.Template.TransConfig_();
				transConfig.TransMode = context.StringValue("SearchTemplate.TemplateList["+ i +"].TransConfig.TransMode");
				template.TransConfig = transConfig;

				SearchTemplateResponse.Template.MuxConfig_ muxConfig = new SearchTemplateResponse.Template.MuxConfig_();

				SearchTemplateResponse.Template.MuxConfig_.Segment_ segment = new SearchTemplateResponse.Template.MuxConfig_.Segment_();
				segment.Duration = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Segment.Duration");
				muxConfig.Segment = segment;

				SearchTemplateResponse.Template.MuxConfig_.Gif_ gif = new SearchTemplateResponse.Template.MuxConfig_.Gif_();
				gif.Loop = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.Loop");
				gif.FinalDelay = context.StringValue("SearchTemplate.TemplateList["+ i +"].MuxConfig.Gif.FinalDelay");
				muxConfig.Gif = gif;
				template.MuxConfig = muxConfig;

				templateList.Add(template);
			}
			searchTemplateResponse.TemplateList = templateList;
        
			return searchTemplateResponse;
        }
    }
}