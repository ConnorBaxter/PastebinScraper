import requests
from bs4 import BeautifulSoup
from urllib import parse
@client.command()
asyncio def paste(ctx, query):                              # function to search bing for pastes
    dorks = query+" site:pastebin.com"                      # query done to bing to search the pastebin api
    page = 1                                                # number of pages to search
        await ctx.send('SENDING DORK: {}'.format(query))
        await ctx.send('SEARCHING PAGES: {}'.format(page))
        my_headers={'User-agent':'Mozilla/11.0'}            # header/user-agent so you dont get blocked
        url='https://www.bing.com/search'                   # url
        payload={'q':dorks,'first':'0', 'count' : int(page)*10+1}   # post data payload
        r=requests.get(url,params=payload,headers=my_headers)       # request sent to the search engine
        soup=BeautifulSoup(r.text,'html.parser')                    # bs4 search
        litags=soup.find_all('h2')                                  # searching for h2 tags
        for linex in litags:                                        # searching for links
                line2=linex.find_all('a')                           # looking for <a> tags
                for link in line2:                                  # looking for href links related to the <a> tags
                        result=link.get('href')                     # sending href's aka links to the discord server
                        await ctx.send('[ LINK ] ' 
                                       + parse.unquote(result))     # sending output