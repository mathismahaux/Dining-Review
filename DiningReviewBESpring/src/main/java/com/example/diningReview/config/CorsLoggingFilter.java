package com.example.diningReview.config;

import org.springframework.stereotype.Component;

import jakarta.servlet.FilterChain;
import jakarta.servlet.ServletException;
import jakarta.servlet.ServletRequest;
import jakarta.servlet.ServletResponse;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import lombok.extern.slf4j.Slf4j;

import java.io.IOException;

import jakarta.servlet.Filter;

@Slf4j
@Component
public class CorsLoggingFilter implements Filter {
    @Override
    public void doFilter(ServletRequest request, ServletResponse response, FilterChain chain)
            throws IOException, ServletException {

        HttpServletRequest httpRequest = (HttpServletRequest) request;
        HttpServletResponse httpResponse = (HttpServletResponse) response;

        String origin = httpRequest.getHeader("Origin");
        String method = httpRequest.getMethod();

        // Log CORS request details
        log.info("CORS Request: Origin = {}, Method = {}", origin, method);

        // If preflight request, log headers
        if ("OPTIONS".equalsIgnoreCase(method)) {
            log.info("CORS Preflight Request - Headers: {}", httpRequest.getHeaderNames());
        }

        chain.doFilter(request, response);

        // Log CORS response headers
        log.info("CORS Response Headers: {}", httpResponse.getHeaderNames());
    }
}
